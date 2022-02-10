using System;

namespace Autocomplete.Trie
{
    public class Trie : ITire
    {
        private TrieNode _root;

        public Trie()
        {
            _root = new TrieNode();
        }

        public void Insert(string word)
        {
            if (String.IsNullOrEmpty(word))
            {
                return;
            }

            TrieNode node = _root;
            node.Pass++;

            foreach (var w in word)
            {
                var path = w - 'a';
                if (node.Children[path] == null)
                {
                    node.Children[path] = new TrieNode();
                }

                node = node.Children[path];
                node.Pass++;
            }

            node.End++;
        }


        /// <summary>
        /// Search a word in Trie and return the number of times of insertion
        /// </summary>
        /// <param name="word"></param>
        /// <returns>the number of times of word insertion</returns>
        public int Search(string word)
        {
            if (String.IsNullOrEmpty(word))
            {
                return 0;
            }

            TrieNode node = _root;

            foreach (var w in word)
            {
                var path = w - 'a';
                if (node.Children[path] == null)
                {
                    return 0;
                }
                node = node.Children[path];
            }

            return node.End;
        }

        /// <summary>
        /// Get the number of prefix of inserted words
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns>the number of prefix of inserted words</returns>
        public int GetPrefixNumber(string prefix)
        {
            if (String.IsNullOrEmpty(prefix))
            {
                return 0;
            }

            TrieNode node = _root;

            foreach (var p in prefix)
            {
                var path = p - 'a';
                if (node.Children[path] == null)
                {
                    return 0;
                }

                node = node.Children[path];
            }

            return node.Pass;
        }

        public void Delete(string word)
        {
            if (String.IsNullOrEmpty(word))
            {
                return;
            }

            if (Search(word) == 0)
            {
                return;
            }

            TrieNode node = _root;
            node.Pass--;

            foreach (var w in word)
            {
                var path = w - 'a';
                if (--node.Children[path].Pass == 0)
                {
                    node.Children[path] = null;
                    return;
                }

                node = node.Children[path];
            }

            node.End--;
        }
    }
}
