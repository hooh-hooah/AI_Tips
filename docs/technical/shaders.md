# Shader Informations

!> There is no way to implement more than two color options without modding tool's object replica shader. Please keep that in mind

## Available Shaders

### Clothing Shader Replica

?> I recommend seeing the difference between `Opaque Shader`, `Transparent Shader`, `Transparent Cutout Shader` before using those shaders. It's pretty technical, but you're in here, so you might be interested.

You can create your customizable clothing by using these custom shaders to your clothing mesh's material.

Keep in mind that these are "Replicas", not the same shader they use in the game.

#### Variants

-   Opaque
-   Cutout
-   Cutout + Alpha Blending

#### Known Parameters

| Type    | Parameter            | Adjustable In-Game | Description                                                |
| ------- | -------------------- | ------------------ | ---------------------------------------------------------- |
| Texture | `DetailNormalMap2`   | ❌                 | The Detail Normal texture for high quality pattern.        |
| Texture | `DetailNormalMap`    | ❌                 | The Detail Normal texture for high quality pattern.        |
| Texture | `BumpMap`            | ❌                 | The Bumap for showing depth to the texture.                |
| Texture | `DetailGlossMap`     | ✔                  | -                                                          |
| Texture | `DetailMainTex`      | ❌                 | The texture slot reserved for ILLUSION's shader adjustment |
| Texture | `MetallicGlossMap`   | ❌                 | -                                                          |
| Texture | `WeatheringMap`      | ❌                 | -                                                          |
| Texture | `WeatheringMask`     | ❌                 | -                                                          |
| Texture | `AlphaMask`          | ❌                 | -                                                          |
| Texture | `AlphaMask2`         | ❌                 | -                                                          |
| Texture | `DetailGlossMap2`    | ❌                 | -                                                          |
| Texture | `CutoutMap`          | ❌                 | -                                                          |
| Texture | `MainTex`            | ❌                 | The Diffuse texture.                                       |
| Color3  | `Color1`             | ✔                  | -                                                          |
| Color3  | `Color2`             | ✔                  | -                                                          |
| Color3  | `Color3`             | ✔                  | -                                                          |
| Color3  | `Color1_2`           | ✔                  | -                                                          |
| Color3  | `Color2_2`           | ✔                  | -                                                          |
| Color3  | `Color3_3`           | ✔                  | -                                                          |
| Color3  | `Emission`           | ❌                 | -                                                          |
| Color3  | `MaskClipValue`      | ❌                 | -                                                          |
| Float   | `BumpScale`          | ❌                 | Sets how strong is `BumpMap`.                              |
| Float   | `DetailNormalScale`  | ❌                 | Sets how strong is `DetailNormalMap`.                      |
| Float   | `DetailNormalScale2` | ❌                 | Sets how strong is `DetailNormalMap2`.                     |
| Float   | `OcclusionStrength`  | ❌                 | Sets how strong is `OcclusionMap`.                         |

### Object Shader Replica

#### Variants

-   Opaque
-   Cutout
-   Cutout + Alpha Blending

#### Known Parameters

| Type    | Parameter            | Adjustable In-Game | Description                                                |
| ------- | -------------------- | ------------------ | ---------------------------------------------------------- |
| Texture | `DetailNormalMap2`   | ❌                 | The Detail Normal texture for high quality pattern.        |
| Texture | `DetailNormalMap`    | ❌                 | The Detail Normal texture for high quality pattern.        |
| Texture | `BumpMap`            | ❌                 | The Bumap for showing depth to the texture.                |
| Texture | `DetailGlossMap`     | ✔                  | -                                                          |
| Texture | `DetailMainTex`      | ❌                 | The texture slot reserved for ILLUSION's shader adjustment |
| Texture | `MetallicGlossMap`   | ❌                 | -                                                          |
| Texture | `WeatheringMap`      | ❌                 | -                                                          |
| Texture | `WeatheringMask`     | ❌                 | -                                                          |
| Texture | `ColorMask`          | ❌                 | -                                                          |
| Texture | `CutoutMap`          | ❌                 | -                                                          |
| Texture | `MainTex`            | ❌                 | The Diffuse texture.                                       |
| Color3  | `Color1`             | ✔                  | -                                                          |
| Color3  | `Color2`             | ✔                  | -                                                          |
| Color3  | `Color3`             | ✔                  | -                                                          |
| Color3  | `Color1_2`           | ✔                  | -                                                          |
| Color3  | `Color2_2`           | ✔                  | -                                                          |
| Color3  | `Color3_3`           | ✔                  | -                                                          |
| Color3  | `Emission`           | ❌                 | -                                                          |
| Color3  | `MaskClipValue`      | ❌                 | -                                                          |
| Float   | `BumpScale`          | ❌                 | Sets how strong is `BumpMap`.                              |
| Float   | `DetailNormalScale`  | ❌                 | Sets how strong is `DetailNormalMap`.                      |
| Float   | `DetailNormalScale2` | ❌                 | Sets how strong is `DetailNormalMap2`.                     |
| Float   | `OcclusionStrength`  | ❌                 | Sets how strong is `OcclusionMap`.                         |

### Special Use Shaders

#### Coom Shader

Yes, this shader is for that kind of purpose.

### Architect Shader

Triplanar PBR Texture shader

### RMA Standard Shader

RMA shader is for a texture set from Unity Engine or other rendering engines packed with a specific format.

RMA stands for "Roughness, Metallic and Ambient Occlusion". as you can guess, RMA Texture contains all of that information in one texture, unlike the Unity Engine's default standard shader.

Converting all of those textures to the Unity Engine's format would be a real pain. So consider to use this shader when you've got some nice asset but in RMA format.

#### Variants

-   Opaque
-   Cutout
-   Cutout + Alpha Blending

#### Known Parameters

| Type    | Parameter          | Adjustable In-Game | Description                                                            |
| ------- | ------------------ | ------------------ | ---------------------------------------------------------------------- |
| Texture | `MainTex`          | ✔                  | The Diffuse texture.                                                   |
| Texture | `NormalMap`        | ✔                  | The Normal map Texture                                                 |
| Texture | `EmissionTex`      | ✔                  | The Diffuse texture.                                                   |
| Texture | `RMA`              | ✔                  | `Red`: Roughness<br />`Green`: Metallic<br />`Blue`: Ambient Occlusion |
| Color3  | `Color`            | ✔                  | The Normal map Texture                                                 |
| Color3  | `EmissionColor`    | ✔                  | The Diffuse texture.                                                   |
| Float   | `EmissionStrength` | ✔                  | The Diffuse texture.                                                   |

## Amplify Shader Editor Functions

### Anisotropic Specualr Highlight

### RMAShaderFunction
