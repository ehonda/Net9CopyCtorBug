# Overview

ℹ️ **This bug was fixed!** It is not present anymore, if `.NET SDKs` in versions `8.0.407` and `9.0.202`. It was present in
the combination of `8.0.206` and `9.0.103`, which is when this was written up.

This is a demo for a bug involving

* A base `record` in a nuget built with `net8.0`
* A derived `record` in an application built with `net9.0`, that also has a property with the `required` modifier not
  set from the constructor

The described setup will then result in a missing call to the base copy constructor in the derived record's implicitly
generated copy constructor.
