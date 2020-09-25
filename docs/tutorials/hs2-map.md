# Creating Custom HS2 In-Game Map

!> Honey Select 2 Main-Game Map Integration is still in development. There might be unexpected critical failures that I missed to fix. Reporting bug is one of way to contribute to development and save everyone's time.

## Related Document

This page only contains how to put hair models into the game with adjustable attributes.

If you need more basic information like setup folders or preparing hair assets, please visit the pages below before continuing to read this document:

-   [Getting Started with the hooh's Modding Tool](getting_started.md)
-   [Setting up Folder](tutorials/gearing-up.md)
-   [Studio Maps](tutorials/studio-map.md)

## Steps

### Putting Assets

!> `.OBJ` format does not supports FK studio items. Make sure that you're importing `.FBX` format 3D Mesh Files to make FK works on the model.

![](imgs/std_00.png)

Import or make the 3D asset and drag and drop into `assets` folder in your mod folder

It would be best to import all textures, models, and all other required assets to the Unity Editor.

### Setup the map

It is good to setup the map first since hs2 map conversion is irreversible

### Initialzie HS2 Map

!> Don't forget to make the copy of the map! This is IREVERSIBLE!

press backup map and nut and go

### Adjust HPoints

adjust hpoints.

there might be unnesasry hpoints since your map's theme is limited to certain actions

you can show and hide objects for each hpoint. useful for desk hscenes

### Adjust Map Informations

adjust default light brightness and colors

### Make MapInfo Script

-   Fill things manually
-   Using auto-fill
    to use auto-fill you need to follow the naming convention
    the mod.xml must be filled before the automatic run

### Make Map Scene Info

!> This step will be taken care of in near future since this is dumb

make map camera info -

### Optional: Make Map Collider

### Build Mod

![](imgs/mod_00.png)

Drag and drop your custom mod XML file into the mod builder's target window.

After setting the build target, check if the output path is where you desire to put your custom zipmod archive.

If everything is okay, validate your XML file if you didn't make any mistake inside the XML file.

Unless a mod packer cannot find an asset or has some issue while resolving the Asset Bundle's path, it says nothing.

Then you're good to go. Press the big green button and to build the mod.

It depends on your mod size, but it will play a nice sound to notify the packing is done after a few seconds or minutes.

### Trouble Shooting

!> If you can't find the issue here, then check [**Trouble Shooting**](tutorials/trouble-shooting.md) page.
