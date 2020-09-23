# How to preview Hair Material in Unity Editor

## Requirement

-   Unity 2018.4.11
-   Eyes
-   Eyesockets

## Steps

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

## Caution

1. You can't include assetbundle-loaded materials into assetbundle buildlist.
2. All of preview is temporary to the session. Restarting unity might break the texture.
