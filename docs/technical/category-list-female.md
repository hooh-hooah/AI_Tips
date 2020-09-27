# ALL Possible Female Items Category

?> Most of them work, there might be edge case that I couldn't tested. Since the Document is really long, I suggest you to search around with Ctrl+F key.

### Female Head

```xml
<list type="fhead">
  <item id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb="">
</list>
```

-   Key Name: `fhead`
-   Description: Female Head
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `head-object`: The name of the head prefab asset.
    -   `head-bundle`: The path of assetbundle for the head prefab asset.
    -   `shape-anime`: The name of the head morph asset. The face information is hardcoded to `list/customshape.unity3d`
    -   `mat-data`: Custom material information for rendering the face. References from `head-bundle`. `ChaControl.InitBaseCustomTextureFace` is utilizing this value.
    -   `preset`: Loads face preset from the `head-bundle`. Messagepack seralized file is required.

### Female Face Skin

```xml
<list type="fskinf">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `fskinf`
-   Description: Female Face Skin
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.
    -   `tex-o`: The occlusion texture.
    -   `tex-n`: The normalmap texture.
    -   `head-id`: The head id of the texture. Face texture is Face-type dependent. Make sure that your texture is referencing correct face type.

### Female Face Detail

```xml
<list type="fdetailf">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `fdetailf`
-   Description: Female Face Detail
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Female Body Skin

```xml
<list type="fskinb">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `fskinb`
-   Description: Female Skin Body
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Female Body Detail

```xml
<list type="fdetailb">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-o="" tex-n=""/>
</list>
```

-   Key Name: `fdetailb`
-   Description: Female Skin Detail
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a` or `tex-o`: The occlusion texture.
    -   `tex-n`: The normalmap texture.

### Female Sun Burn

```xml
<list type="fsunburn">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `fsunburn`
-   Description: Female Sunburn
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Female Top

```xml
<list type="ftop">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `ftop`
-   Description: Female Top Clothing
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `coordinate`:
        -   `0`: Normal Clothing
        -   `1`: Set Clothing (Takes top and bottom slot at the same time).
    -   `no-bra`: Disable inner-top slot while this item is active.

### Female Bottom Clothing

```xml
<list type="fbottom">
  <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main="" tex-mask=""
    tex-main2="" tex-mask2="" breakmask-tex="" bramask-bundle="" innermask-tb-tex=""
    innermask-tb-bundle="" innermask-b-tex="" innermask-b-bundle="" panstmask-tex=""
    panstmask-bundle="" bodymask-b-tex="" bodymask-b-bundle="" tex-main3="" tex-mask3=""
  />
    <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fbottom`
-   Description: Female Bottom Clothing
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `breakmask-tex`: The name of the alphamask for cloth tearing
    -   `bramask-bundle`: The bundle path for the bra alphamask texture.
    -   `innermask-tb-tex`: The name of the alphamask texture for coordinate type innertop.
    -   `innermask-tb-bundle`: The bundle path for the coordinate type innertop alphamask texture.
    -   `innermask-b-tex`: The name of the alphamask texture for innerbottom.
    -   `innermask-b-bundle`: The bundle path for the innerbottom alphamask texture.
    -   `panstmask-tex`: The name of the alphamask texture for pantystocking.
    -   `panstmask-bundle`: The bundle path for the pantystocking alphamask texture.
    -   `bodymask-b-tex`: The name of the alphamask texture for bottom body.
    -   `bodymask-b-bundle`: The bundle path for the bottom body alphamask texture.
    -   `tex-main3`: The name of the diffuse texture of clothing. Used for changing Color3 in the game.
    -   `tex-mask3`: The name of the colormask texture of clothing. Used for changing Color3 in the game.

### Female Inner Top

```xml
<list type="fintop">
  <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main="" tex-mask=""
    tex-main2="" tex-mask2="" hide-bottom="" coordinate="" overbra-type=""
    overbra-tex="" overbra-bundle="" bodymask-tex="" bodymask-bundle=""
    bramask-tex="" breakmask-tex="" bramask-bundle="" innermask-tb-tex=""
    innermask-tb-bundle="" innermask-b-tex="" innermask-b-bundle="" panstmask-tex=""
    panstmask-bundle="" bodymask-b-tex="" bodymask-b-bundle=""
    tex-main3="" tex-mask3=""
  />
    <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fintop`
-   Description: Female Inner Top Clothing
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `hide-bottom`: Whether the item is disabling rendering the bottom or not.
    -   `coordinate`:
        -   `0`: Normal Clothing
        -   `1`: Set Clothing (Takes top and bottom slot at the same time).
    -   `overbra-type`: This value is not used nor referenced in the game.
    -   `overbra-tex`: The name of the alpha mask texture for bra.
    -   `overbra-bundle`: The bundle path for the bra alphamask texture.
    -   `bodymask-tex`: The name of the alphamask for upper body
    -   `bodymask-bundle`: The bundle path for the upper body alphamask texture.
    -   `bramask-tex`: The name of the alphamask texture for innertop.
    -   `breakmask-tex`: The name of the alphamask for cloth tearing
    -   `bramask-bundle`: The bundle path for the bra alphamask texture.
    -   `innermask-tb-tex`: The name of the alphamask texture for coordinate type innertop.
    -   `innermask-tb-bundle`: The bundle path for the coordinate type innertop alphamask texture.
    -   `innermask-b-tex`: The name of the alphamask texture for innerbottom.
    -   `innermask-b-bundle`: The bundle path for the innerbottom alphamask texture.
    -   `panstmask-tex`: The name of the alphamask texture for pantystocking.
    -   `panstmask-bundle`: The bundle path for the pantystocking alphamask texture.
    -   `bodymask-b-tex`: The name of the alphamask texture for bottom body.
    -   `bodymask-b-bundle`: The bundle path for the bottom body alphamask texture.
    -   `tex-main3`: The name of the diffuse texture of clothing. Used for changing Color3 in the game.
    -   `tex-mask3`: The name of the colormask texture of clothing. Used for changing Color3 in the game.

### Female Inner Bottom

```xml
<list type="finbottom">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `finbottom`
-   Description: Female Inner Bottom Clothing
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `hide-bottom`: Whether the item is disabling rendering the bottom or not.

### Female Gloves

```xml
<list type="fgloves">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fgloves`
-   Description: Female Gloves
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.

### Female Pantyhose

```xml
<list type="fpanst">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fpanst`
-   Description: Female Pantystocking
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `hide-bottom`: Whether the item is disabling rendering the bottom or not.

### Female Socks

```xml
<list type="fsocks">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fsocks`
-   Description: Female Socks
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.

### Female Shoes

```xml
<list type="fshoes">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fshoes`
-   Description: Female Shoes
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
