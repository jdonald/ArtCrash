This demonstrates the Unity 4 bug as described here:
  http://forum.unity3d.com/threads/art-runtime-support.223802/

To reproduce, install ArtCrash.apk on any Android device
where the runtime has been switched to ART (Developer options ->
Select runtime -> Use ART).

This has been verified on a Nexus 5 as well as the Google
Tango tablet. On a Nexus 5, it typically crashes after
500 frames (~9 seconds).
