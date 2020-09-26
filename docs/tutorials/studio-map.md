# Creating Custom Studio Map

## Related Documents

If you need more basic information like setup folders or preparing hair assets, please visit the pages below before continuing to read this document:

-   [Getting Started with the hooh's Modding Tool](getting_started.md)
-   [Setting up Folder](tutorials/gearing-up.md)

## Steps

### Prepare Scene

![image-20200101043939311](images/image-20200101043939311.png)

Preparing the scene is a simple step. Just place the things as you want until it looks like a good map to enjoy with your characters.

### Add Scale to measure the map's size.

There is a `Character Scale Measurement` prefab that helps you scale your map into AI-shoujo's size. That cylinder is the average character size in AI-shoujo.

Most of the map will be fine if you scale 9x times larger than the original size. But I recommend you adjust the map scale with some visual reference like the doors or desks.

### (Optional) Place Lights

Since most people are not experts in lighting, it's good to put some lights and make scene static to make everyone look good.

You can bake lightmaps and reflection probe, light probes to get extra good quality.

### Make Everything in Layer 11 (Map)

![image-20200101044239224](images/image-20200101044239224.png)

Everything should be in Layer 11 to get properly lighted in-game. Otherwise, it will not get lit by any lights in the game.

### Save Scene

![image-20200101044321024](images/image-20200101044321024.png)

Save the scene to your mod folder. To avoid confusion, I recommend making a folder like `scenes` or `map00`.

But do not put multiple maps into one folder if the level has baked lightmaps. But you can put variants of the map that is using the same lightmap in the same folder.

### Creating Mod XML

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

!> The GUID, bundle name, build name should be **unique**, and you can only refer files in Asset Bundles in the Mod XML File.

You can check the comment inside of the XML Code section above to see what to do.

For more detailed information, you can check those documents for reference.

-   [XML File Structure](technical/xml-file.md) for general Mod File Information
-   [Auto-Path Lists](technical/autopath-list.md) for `<folder auto-path>`
-   [XML List Types](technical/category-list.md) for `<list type>` and `<item>`

### Build Mod

![](imgs/mod_00.png)

Drag and drop your custom mod XML file into the mod builder's target window.

After setting the build target, check if the output path is where you desire to put your custom zipmod archive.

If everything is okay, validate your XML file if you didn't make any mistake inside the XML file.

Unless a mod packer cannot find an asset or has some issue while resolving the Asset Bundle's path, it says nothing.

Then you're good to go. Press the big green button and to build the mod.

It depends on your mod size, but it will play a nice sound to notify the packing is done after a few seconds or minutes.

### Test In-Game

Test your map is working in the game. You can find your custom map in the map section.

### Trouble Shooting

!> If you can't find the issue here, then check [**Trouble Shooting**](tutorials/trouble-shooting.md) page.

#### My map is weirdly placed in the game.

Place Root Object of Map `Position 0,0,0`, `Angle 0,0,0`, and `Scale 1,1,1` in `Transform` Component Inspector.

#### Map does not get lit by any lightings

Ensure that all of the game objects in `Layer 11 (Map)`. As I wrote in the Document, It will not get lit unless the objects are in the `Layer 11 (Map)`.
