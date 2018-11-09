# EasySerializableConverter

![image](https://imgur.com/Jjk0GyN.png)

This is a UI tool for reading source files, then creating serialized data sets. Currently, the meta class handling portion is completed allowing the editing of primitives and enumerable primitives, a basic XML serialiser is currently included for better insight when debugging the program, it is set to be replaced.

Contributors: Please check the //TODO tags for things that need to be done.

Some things that are currently lacking:

* A source file reader that could turn a source file (.js, .ts, .cs) into an instance of class `ClClass` so that we could input this instance into the UI generator.
* Better UI to deal with enumerables (lists, arrays, etc)
* Customised Serialiser to properly serialise everything
