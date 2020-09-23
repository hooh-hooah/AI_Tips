# Making Studio Map Tutorial

## Related Document

This page only contains how to put hair models into the game with adjustable attributes.

If you need more basic information like setup folders or preparing hair assets, please visit the pages below before continuing to read this document:

-   [Getting Started with the hooh's Modding Tool](getting_started.md)
-   [Setting up Folder](tutorials/gearing-up.md)

## Table of Content

1. [Prepare Scene](#Prepare Scene)

## Steps

### Prepare Scene

![image-20200101043939311](images/image-20200101043939311.png)

##### Add Scale to measure the map's size.

There is `Character Scale Measurement` prefab that helps you to scale your map into AI-shoujo's size. That cylinder is average character size in AI-shoujo.

Most of map will be fine if you scale 9x times larger than original size. but don't forget to scale it properly.

##### (Optional) Place Lights

Since not most of people are not expert of lights so it's good idea to put some lights and make scene static to make look good for everyone.

You can bake lightmaps and reflection probe, light probes to get extra good quality

##### Make Everything in Layer 11 (Map)

![image-20200101044239224](images/image-20200101044239224.png)

Everything should be in Layer 11 to get properly lighted in-game.

### Save Scene

![image-20200101044321024](images/image-20200101044321024.png)

Save scene like this.

### Make mod.xml

Make your own mod.xml.

here is some example

```xml
<packer>
    <guid>example.studio.map</guid>
    <name>My First Studio Map</name>
    <version>1.0.0</version>
    <author>My Name</author>
    <description>My first outfit mod</description>
    <options>
         <!--
            If you're planning to release studio items with the map,
            I recommend you to put use-dependency on option for more
            perfomance and smaller size of zipmod.
          -->
          <use-dependency />
    </options>
    <bundles>
        <folder auto-path="maps" from="map00" filter=".*\.unity" target="map00" />
    </bundles>
    <build>
        <list type="map">
            <item name="My First Studio Map" scene="map_00" />
        </list>
    </build>
</packer>
```

for detailed information about xml check [**XML File Structure**](technical/xml-file.md) document

for detailed information what to put with `<item>` check [**XML List Types**](technical/category-list.md) document

### Build Mod

![](imgs/mod_00.png)

Drag and drop your custom mod XML file into the mod builder's target window.

After setting the build target, check if the output path is where you desire to put your custom zipmod archive.

If everything is okay, validate your XML file if you didn't make any mistake inside the XML file.

Unless a mod packer cannot find an asset or has some issue while resolving the Asset Bundle's path, it says nothing.

Then you're good to go. Press the big green button and to build the mod.

It depends on your mod size, but it will play a nice sound to notify the packing is done after a few seconds or minutes.

### Test In-Game

Test your clothes working in-game.

### Trouble Shooting

!> If you can't find the issue in here then check [**Trouble Shooting**](tutorials/trouble-shooting.md) page.

#### My map is kinda weirdly placed.

Place Root Object of Map Position 0,0,0 and Angle 0,0,0 and Scale 1,1,1.

#### Map does not takes any lightings

Check if the map is in Layer 11 (Map)
