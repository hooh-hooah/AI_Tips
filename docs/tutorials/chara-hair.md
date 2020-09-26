# How to make hairs

## Related Documents

This page only contains how to put hair models into the game with adjustable attributes.

If you need more basic information like setup folders or preparing hair assets, please visit the pages below before continuing to read this document:

-   [Getting Started with the hooh's Modding Tool](getting_started.md)
-   [Setting up Folder](tutorials/gearing-up.md)
-   [Preparing Hair Assets](prepping/hair-mesh.md)

## Steps

### Putting Assets

!> `.OBJ` format does not supports FK studio items. Make sure that you're importing `.FBX` format 3D Mesh Files to make FK works on the model.

![](imgs/std_00.png)

Import or make the 3D asset and drag and drop into `assets` folder in your mod folder

It would be best to import all textures, models, and all other required assets to the Unity Editor.

![](./imgs/hairpreview.png)

1. Select any game object to apply hair material.
2. Add Component "DevPreviewHair"
3. Go to folder where you stored your hair textures.
4. Press Assign Textures or Drag and Drop textures manually to Textures Area.
   Assign Textures will seek for:
    - Any Texture that contains word "color" in the name but does not have word "mask" in the name
    - Any Texture that has "normal" in the name.
    - Any Texture that has "ao", "ambient", "occlusion" in the name.
    - Any Texture that has "noise" in the name.
    - Any Texture that has "colormask" in the name.
5. Check if all textures are assigned.
6. Press Initialize

### Setup Mod XML File

```xml
<packer>
	...
    <bundles>
    	<!-- referencing "tattoo" folder. path is relative to the folder  where mod.xml is present -->
        <folder from="tattoo" auto-path="textures" filter=".+\.(png|tga|tif|psd)"/>
	</bundles>
	<build name="example_bodypaint">
		<list type="spaint">
			<item kind="" possess="" name="My Custom Tattoo" tex-a="TextureName" tex-g="TextureName2" thumb="ThumbnailName"/>
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

## Caution

1. You can't include assetbundle-loaded materials into assetbundle buildlist.
2. All of preview is temporary to the session. Restarting unity might break the texture.

### Trouble Shooting

!> If you can't find the issue here, then check [**Trouble Shooting**](tutorials/trouble-shooting.md) page.
