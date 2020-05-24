
# Development Environment

This is not really meant as an explanation on how to build this specific project. It's also not a real tutorial, It's probably better if you
stick to the official tutorial by Oculus. This is more of a learning log as I'm creating my first VR unity project. It might help me to see how or why
I did a thing :P.

## [Unity](https://unity.com/)

> https://developer.oculus.com/documentation/unity/book-unity-gsg/

### Install Unity

+ Unity Hub 2.3.1
+ Unity Version 2019.3.14f1, installed via Unity Hub on OS X.
+ Additional Modules installed
    + Android Build Support (Android SDK & NDK, OpenJDK)
    + Mac Build Support (probably not needed for Oculus Quest)
    + Documentation

### Create new project

+ Select "3D Project"
+ Stored project in ../unity sub folder
+ Added unity .gitignore to ignore thousands of generated files ;-)

### Enable device for testing

> https://developer.oculus.com/documentation/unity/unity-enable-device/

+ Enable developer mode on Oculus Quest. (Oculus App -> Settings -> Select Headset -> More Settings -> Developer Mode)
+ Connect device with USB & confirm dialog in headset
+ Verify that headset is visible in Unity. (Unity -> File -> Build Settings -> Android -> Run Device)
+ "Build And Run" to verify everything is working. This launches a 2D scene..

I've skipped the ADB part of the instructions since I don't expect to need this right now.

### Import Oculus Quest Integration Package

> https://developer.oculus.com/documentation/unity/unity-import/

+ Open Asset store and search for "Oculus Integration" -> Download -> Import (keep everything selected)
+ Select upgrade & restart whenever asked
+ add third party assets to .gitignore. I'll try to ignore any third party assets and hopefully I'll still be able to use git to rollback unwanted changes etc. It's a bit of a pain to manage that. I've considered creating a private repo for the whole project but I kinda like being able to share code snippets.. so I'll try to ignore any third party files for now and see how it goes.

### Configure Unity project

> https://developer.oculus.com/documentation/unity/unity-conf-settings/

+ Unity -> File -> Build Settings
    + Texture Compression: [ASTC](https://en.wikipedia.org/wiki/Adaptive_Scalable_Texture_Compression)
        + Setting this seems to prompt unity to do a bunch of re-indexing.. so I had time to read what ASTC actually is
    + Run device: the oculus quest headset obviously
    + Development build: enable for now, disable for final build
    + Click Switch Platform if a notice pops up
    