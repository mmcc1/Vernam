# Vernam
Multiple implementations of the Vernam cipher.

Currently has two implementations.  The first uses a typical random key the same length as the file.  The second implementation employs SHA512 to construct the key.

Vernam Hash

VernamHash takes a 512 bit key which drives a SHA512 hashing process to generate a key the same size of the file. It much more portable than traditional Vernam implementations as it does require distribution of random numbers. 

The Vernam cipher is secure if, and only if, the following conditions are all met:

* There are only two copies of the key,
* Both sides of the communications link have the same key,
* The key is used only once,
* The key is destroyed immediately after use,
* The key contains truly random characters,
* The equipment is TEMPEST proof,
* The key was not compromised during transport.

More on the theory:
https://www.cryptomuseum.com/crypto/vernam.htm
