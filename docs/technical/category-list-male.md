# ALL Possible Male Items Category

?> Most of them work, there might be edge case that I couldn't tested. Since the Document is really long, I suggest you to search around with Ctrl+F key.

### Male Head

```xml
<list type="mhead">
  <item id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb="">
</list>
```

-   Key Name: `mhead`
-   Description: Male Head
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

### Male Face Skin

```xml
<list type="mskinf">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `mskinf`
-   Description: Male Face Skin
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

### Male Face Detail

```xml
<list type="mdetailf">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `mdetailf`
-   Description: Male Face Detail
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

### Male Beard Texture

```xml
<list type="mbeard">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `mbeard`
-   Description: Male Beard
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

### Male Body Skin

```xml
<list type="mskinb">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `mskinb`
-   Description: Male Skin Body
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

### Male Body Detail

```xml
<list type="mdetailb">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-o="" tex-n=""/>
</list>
```

-   Key Name: `mdetailb`
-   Description: Male Skin Detail
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

### Male Sunburn

```xml
<list type="msunburn">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `msunburn`
-   Description: Male Sunburn
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

### Male Top

```xml
<list type="mtop">
  <item id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main="" tex-mask=""
    tex-main2="" tex-mask2="" coordinate="" overbra-type="" overbra-tex=""
    overbra-bundle="" bodymask-tex="" bodymask-bundle="" bramask-tex=""
    breakmask-tex="" bramask-bundle="" innermask-tb-tex="" innermask-tb-bundle=""
    innermask-b-tex="" innermask-b-bundle="" panstmask-tex="" panstmask-bundle=""
    bodymask-b-tex="" bodymask-b-bundle="" tex-main3="" tex-mask3="" />
      <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `mtop`
-   Description: Male Top Clothing
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

### Male Bottom

```xml
<list type="mbottom">
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

-   Key Name: `mbottom`
-   Description: Bottom Clothing
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

### Male Gloves

```xml
<list type="mgloves">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `mgloves`
-   Description: Male Gloves
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

### Male Shoes

```xml
<list type="mshoes">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `mshoes`
-   Description: Male Shoes
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
