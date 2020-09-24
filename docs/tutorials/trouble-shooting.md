# Trouble Shooting

Was it not going well? It's time to fix some problems.

## Things we can't fix.

### The hair shader is blocky! (Dithering Hair Shader)

Dithering is something we need to bear. "Deal with it."

### I can't use more than one material for hair.

You can't.

## Common Mistakes

### Modding tool is not building the mod

There are two possibilities:

-   You're trying to build the mod while the game is open. Once the game is running, every single zipmod is write-locked, so you can't update your mod.
-   When the modding tool failed to validate your assets, it will refuse to build the mod to save your time.
    You can see the why mod packer is failed to resovle mod assets.

### Studio Lights not affecting to your mods

Check your studio item's layer. Studio Lights will only lit items with a specific layer.

-   Map Layer will only lit by Map Lights.
-   Chara Layer will only lit by Chara Lights.

### SB3Utility Fails

When SB3Utility failed to find external texture, SB3Utility might fail to run.
Currently, SB3Utility can't reference external texture from scratch (Based on the author's comment).
To use ILLUSION's hair shader with external texture, the hair mesh material must reference all of the textures to swap.

### I can see my mod in the creator, but it won't load when I click it

There are a few things that are responsible for that issue:

-   The mesh is not `Skinned Mesh Renderer`.
-   The prefab does not have a `CmpClothes` Component.
-   The layer of prefab is not in the `Chara` Layer.
-   The mesh/prefab is not 1.0 scale.
-   The game failed to load the Asset Bundle.
-   You need to see `output_log.txt` in your game's root folder to resolve this issue.
-   It is a hard task, and it will take a pretty long time if you are not experienced.

## Faulty Assets

### The model's reflection is weird.

Please recalculate the normal of your asset.
It's called 'Bad Normal'. If your item looks like a googled result, please reference its fix in youtube or stack overflow.

### It looks all right in 3D Software, but the clothing/FK item going nut in the Unity Editor/Main-Game

The Unity Engine only allows four vertex groups per vertex. Which means only four bones can influence to vertex's position.
It would be best to clean up vertex groups before exporting the 3d model to the unity engine.
There is no way to lift this limit unless we get 2019.x+ Unity Engine.

## Systemic Fault

### Lightmap is not baking

Unity Editor's problem. Please reference official manuals. The Unity Editor's lightmap baker is... pretty complicated.
Please understand that I'm not a professional Game Developer.
