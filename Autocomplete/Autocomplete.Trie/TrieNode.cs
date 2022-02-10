using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocomplete.Trie
{
    class TrieNode
    {
        // The number of times a lower case letter passes a node of prefix tree
        public int Pass { get; set; }

        // The number of times a lower case letter ends in a node of prefix tree
        public int End { get; set; }
        
        // The 26 paths for 26 lower case letters. Ex. Children[0] is the path of 'a'
        // Children[i] == null then the path to i does not exist
        // Children[i] != null then the path ot i exists
        public TrieNode[] Children { get; }

        public TrieNode()
        {
            this.Pass = 0;
            this.End = 0;
            this.Children = new TrieNode[26];
        }

    }
}
