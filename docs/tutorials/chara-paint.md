# How to make Body Paint

## Related Document

This page only contains how to put hair models into the game with adjustable attributes.

If you need more basic information like setup folders or preparing hair assets, please visit the pages below before continuing to read this document:

-   [Getting Started with the hooh's Modding Tool](getting_started.md)
-   [Setting up Folder](tutorials/gearing-up.md)

## Steps

### Make A Texture

First, fill whole layer with white and go to channel and make an alpha texture.

Here all all that matters. Alpha channel is the most important thing in order to make a bodypaint/partial pant texture.

![image-20200214072029064](images\image-20200214072029064.png)

### Save Textures with Import

After making textures, place all textures inside of one folder. don't forget to make dummy mod.xml folder. (or use example's one)

![image-20200214072443472](images\image-20200214072443472.png)

Import Textures with this option. It's very important to apply Transparency on to your texture.

![image-20200214072527660](images\image-20200214072527660.png)

### Setup mod.xml

```xml
<packer>
	...
    <bundles>
    	<!-- referencing "tattoo" folder. path is relative to the folder  where mod.xml is present -->
        <folder from="tattoo" auto-path="textures" filter=".+\.(png|tga|tif|psd)"
    </bundles>
	</bundles>
	<build name="example_bodypaint">
		<list type="spaint">
			<item kind="" possess="" name="My Custom Tattoo" tex-a="TextureName" tex-g="TextureName2" thumb="ThumbnailName"/>
		</list>
	</build>
</packer>
```

Check [this file](https://github.com/hooh-hooah/ModdingTool/blob/release/Assets/%40BODY_PARTS/facepaint/mod.xml) and copy and paste it.

You need to remember that guid, bundle name, build name should be **unique** and you can only refer files in assetbundles in build.xml.

### Build Mod

![](imgs/mod_00.png)

Drag and drop your custom mod XML file into the mod builder's target window.

After setting the build target, check if the output path is where you desire to put your custom zipmod archive.

If everything is okay, validate your XML file if you didn't make any mistake inside the XML file.

Unless a mod packer cannot find an asset or has some issue while resolving the Asset Bundle's path, it says nothing.

Then you're good to go. Press the big green button and to build the mod.

It depends on your mod size, but it will play a nice sound to notify the packing is done after a few seconds or minutes.

### Trouble Shooting

!> If you can't find the issue in here then check [**Trouble Shooting**](tutorials/trouble-shooting.md) page.
