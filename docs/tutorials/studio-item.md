# How to make Studio Item

## Related Document

This page only contains how to put hair models into the game with adjustable attributes.

If you need more basic information like setup folders or preparing hair assets, please visit the pages below before continuing to read this document:

-   [Getting Started with the hooh's Modding Tool](getting_started.md)
-   [Setting up Folder](tutorials/gearing-up.md)

## Steps

Follow this if you're diagnosed to live for 60 seconds.

-   Put your 3d models and textures inside of assets
-   Drag the model and adjust the materials and stuff
-   Combine the things you want to import into the game in one GameObject
-   Click "Common > Studio" Item after clicking the combined object
-   Drag the prefab to "prefabs" folder
-   Open mod.xml
-   Add like this
-   Drag mod.xml to the mod builder
-   Press Build Mod
-   Good, you're done

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

## Field Manual

### When your studio mod is so big and each prefab shares many things in common

_Difficulty: Lazy_

-   Separate texture sets with several subfolders
-   include `<use-dependency>` option mod.xml here is the example.
-   Now Mod Packer will pack textures in separate bundles and each prefab bundles will reference that texture.
-   Keep in mind that once you enabled this option your mod is now dependent to "Dependency Loader Plugin"

#### When you want to check if mod.xml is valid without building the mod

_Difficulty: Sloth_

-   Press the "Dry Run" Button inside of the Mod Builder Menu.
-   If everything is good, it will not display any message but a nice blip sound.
-   If something went wrong, it will display some dialog and print detailed information to the unity console.
-   You can open the unity console with the "Ctrl+Shift+C" key anywhere.

### When you want to add stylized Studio Item Thumbnails

_Difficulty: Low_

-   Make Foreground Image or Background Image. It can be transparent but the result icon will not be transparent due to the policy of the Item Finder Plugin

-   Make sure that those images that you've mode are 64x64 image. It is recommended to have smaller size icons.

-   Make sure that those images that you've made are **"Read/Write Enabled"** or unity will refuse to utilize your foreground/background texture.

    ![1600689442803](C:\Users\carla\AppData\Roaming\Typora\typora-user-images\1600689442803.png)

-   Make sure your studio items are registered inside of mod.xml (Studio Thumbnail Generator will only generate registered items inside of mod.xml)

-   Drag and drop prefabs to Thumbnail Generator (or press the "Add Folder" Button to register all of the prefabs inside the folder that you're looking at)

-   Press the "Generate Thumbnails" Button to generate thumbnails.

-   Add `<move>` tag to your mod.xml here is some template with an explanation.

### When you have to generate dozens of studio items into mod.xml

_Difficulty: Confusing sometimes_

-   Go to the "hooh's Modding Tool" window and navigate to the "Mod Scaffolding".

    ![1600689487533](C:\Users\carla\AppData\Roaming\Typora\typora-user-images\1600689487533.png)

-   Go to the prefab folder where prefabs are stored.

-   Drag and drop prefabs to the "Prefabs to put in XML file". You can drag multiple objects by dragging objects right above the text.

    ![1600689509177](C:\Users\carla\AppData\Roaming\Typora\typora-user-images\1600689509177.png)

-   As the title suggests, it will automatically register the prefabs you've dragged into the XML file.
-   Adjust the big category and mid category number to what you want to use. be sure that those ids are not in use or you're going to have some bad time solving the conflict in the game.

### When you have to make things colorable

_Difficulty: Easy_

-   Once you initialized the studio component with the "Initialize Mod Components" in the transform window, basically it's colorable.

_Difficulty: Nut_

-   If you need to make different parts colored with 3 different colors in the studio you'll need a lot of works. prepare some meals before doing this.
-   You need a basic understanding of 3D art from this point. If you don't know "Materials", "UV Map", "Texture Painting", "Basic of Blender" then I suggest you look at those first before doing this.

### When you have to add your own component

_Difficulty: Chad_

-   If you want to add a new custom script component embedded into your studio item you need to understand how C# and Unity are working.
-   There is no way to add the custom component unless it's registered in the main/studio game like "Lux Water", "MirrorReflection".
-   Custom script will not work with a custom plugin. If you have some plan to add an awesome thing, it is a good time to set up a GitLab Account.
-   Since the whole process is too large, I'm going to pinpoint the landmark where you need to focus on this document. - You still can hit me up or ask for help in the "#moddiscussionn" in the "Illusion Discord Server"
-   All of your custom components need to have a custom namespace to be loaded with the Asset Bundle natively.
-   You can set up a custom namespace with the "Assembly Definition" feature in the Unity. I suggest you read the official document before trying it out by yourself.
-   Your custom plugin must have the same namespace as Assembly Definition you've registered in your unity project.
-   You need to code your own control UI and Save/Load values to adjust values on the go in a nice manner.
-   Do not include editor features inside of the component. please filter them out with pre-processor block

### When you have to animate your studio item

_Difficulty: Nasty_

-   You need basic animation for your model. Animate with 3D software like blender or animate with unity.
