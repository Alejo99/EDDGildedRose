# EDD Gilded Rose Refactoring Kata

This Kata was originally created by Terry Hughes (http://twitter.com/TerryHughes). It is already on GitHub [here](https://github.com/NotMyself/GildedRose). See also [Bobby Johnson's description of the kata](http://iamnotmyself.com/2011/02/13/refactor-this-the-gilded-rose-kata/).

As Bobby Johnson points out in his article ["Why Most Solutions to Gilded Rose Miss The Bigger Picture"](http://iamnotmyself.com/2012/12/07/why-most-solutions-to-gilded-rose-miss-the-bigger-picture), it'll actually give you
better practice at handling a legacy code situation if you do this Kata in the original C#. However, I think this kata
is also really useful for practicing writing good tests using different frameworks and approaches, and the small changes I've made help with that.

## How to use this Kata

The simplest way is to just clone the code and start hacking away improving the design. You'll want to look at the ["Gilded Rose Requirements"](https://github.com/Armen99/EDDGildedRose/blob/master/GildedRoseRequirements.txt) which explains what the code is for.
I strongly advise you that some tests have been done in a popular test framework to make sure you don't break the code while you refactor. Anyway, you can also write some unit tests yourself using the requirements to identify suitable test cases.
Keep in mind to pass them while doing the refactor.

Whichever testing approach you choose, the idea of the exercise is to do some deliberate practice, and improve your skills at designing test cases and refactoring. The idea is not to re-write the code from scratch, but rather to practice designing tests, taking small steps, running the tests often, and incrementally improving the design. 
