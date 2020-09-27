# ALL Possible Accessory Category

?> Most of them work, there might be edge case that I couldn't tested. Since the Document is really long, I suggest you to search around with Ctrl+F key.

### Accessroy Slot: None

```xml
<list type="accnone">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accnone`
-   Description: Accessory None Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Head

```xml
<list type="acchead">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `acchead`
-   Description: Accessory Head Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Ears

```xml
<list type="accear">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accear`
-   Description: Accessory Ear Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Glasses

```xml
<list type="accglasses">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accglasses`
-   Description: Accessory Glasses Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Face

```xml
<list type="accface">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accface`
-   Description: Accessory Face Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Neck

```xml
<list type="accneck">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accneck`
-   Description: Accessory Neck Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Shoulder

```xml
<list type="accshoulder">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accshoulder`
-   Description: Accessory Shoulder Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Chest

```xml
<list type="accchest">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accchest`
-   Description: Accessory Chest Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Waist

```xml
<list type="accwaist">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accwaist`
-   Description: Accessory Waist Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Back

```xml
<list type="accback">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accback`
-   Description: Accessory Back Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Arm

```xml
<list type="accarm">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accarm`
-   Description: Accessory Arm Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Hand

```xml
<list type="acchand">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `acchand`
-   Description: Accessory Hand Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Leg

```xml
<list type="accleg">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accleg`
-   Description: Accessory Leg Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Pubic Area

```xml
<list type="acckokan">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `acckokan`
-   Description: Accessory Kokan Slot
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
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```
