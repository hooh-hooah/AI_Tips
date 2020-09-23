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

1. You're trying to build the mod while the game is open. Once the game is running, every single zipmod is write-locked, so you can't update your mod.
2. When the modding tool failed to validate your assets, it will refuse to build the mod to save your time. 

### Studio Lights not affecting to your mods

Check your studio item's layer. Studio Lights will only lit items with a specific layer.

* Map Layer will only lit by Map Lights.
* Chara Layer will only lit by Chara Lights.

### SB3Utility Fails

- Failed to find external texture

  Please refer all textures in material file that you're packing with.

- Invalid Index

  Your mod.xml is not including all textures.

### I can see my mod but it won't load when I click it

This is mostly caused wrong setup of your game object.

1. The hair does not have CmpHair.cs

   You can initialize most of things by clicking Initialize xxxx

2. You forgot something

   Do your clothes scaled properly? Everything should be 1.

   Do your gameobject has skinned mesh renderers?

   Did you included prefab (sometimes you didn't)? 

## Faulty Assets

### The model's reflection is weird.

Please recalculate the normal of your asset.
It's called 'Bad Normal'. If your item looks like a googled result, please reference its fix in youtube or stack overflow.

## Systemic Fault

### Lightmap is not baking

Unity Editor's problem. Please reference official manuals.

## TBD

## Blame hooh

