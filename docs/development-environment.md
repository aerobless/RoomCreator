
# Development Environment

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
+ Stored project in ../unity subfolder
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