# System-Design
The repo contains all proof of concept project with a focus on workable solutions of general system design topics

## TinyUrl
TinyURL is a URL shortening web service, which provides short aliases for redirection of long URLs. The POC includes a http web api of two endpoints to post a long url and to get a short url. The core algorithm implemented in url transformation is explained in the follwing.
#### Long url to Tiny url 
A long url is stored into a relational database and an auto-increment id is generated. The id is changed to a 6-character-long string of base62 number. If the the base62 number is less than 6 character long, character 0 is prefixed. The base62 string contains characters "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ". 
#### Tiny url to Long url 
A tiny url is NOT stored in database. Since a tiny url is just a string of 6 character long of base62 number, the url can be transfomred to a decimal auto increment id. The id is the primary key for selecting the unique correspondent long url.  

## Bloom filter
A Bloom filter is a data structure designed to check, rapidly and memory-efficiently, whether an element is present in a set. The POC is a workable solution to check if a user name has been regeristed with a website. 
