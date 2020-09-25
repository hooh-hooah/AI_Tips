# Preparing Hair Mesh

## Intro

This tutorial is for 3D Modeling Software called Blender. It is free, Open Source, and easy to learn (maybe).

Also, If you're using different 3D Modeling Software like Autodesk Maya or 3dsMax, I assume you already have a basic understanding of how 3d graphics working and how to make toothbrush.

## Steps

### Prepare Assets

![image-20200104213432749](images/image-20200104213432749.png)

Load or import asset on base blender

#### Rigged Hair

![image-20200104213457204](images/image-20200104213457204.png)

rig the hair. unfortunately you need to do it all manually. there is no automated way to rig the hair with nice rig

#### Properly setup UV for hooh's Hair Texture. (Optional)

After then, prepare some nice mesh to put on. You can use any 3d editing tool. The minimum requirement for the hair object is a bone and a mesh.

If you want to make your hair move then you need to add more then 2 bones. also, the more bone is the more smooth it feels.

I'm not going to explain the basic of 3D modeling here. you can go Youtube to search some nice infromations about how to use 3D software. You'll need to learn following things: basic mesh editing, culling, basic setup, vertex weighting, rigging.

!> Currently it's in alpha, you're forced to use or make dummy textures to fit requirements to build hair mod.

Hair mod requires 5 essential textures.

| texture   | description                                                                                                                                                                                                     |
| --------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| diffuse   | still figuring out how it's working but Green Channel is Depth and Red Channel is Diffuse and Alpha Channel is Alpha Cutout. (or dither.)                                                                       |
| normal    | it's a normal map. [just use this flat bumpmap texture if you don't know what to do.](https://docs.unity3d.com/uploads/Main/BumpMapFlatColour.png)                                                              |
| noise     | detail normal map that illusion is using to make it looks like some real hairs. [just use this flat bumpmap texture if you don't know what to do.](https://docs.unity3d.com/uploads/Main/BumpMapFlatColour.png) |
| colormask | colormask for hairs. Red is Main Color, Green is Top Color Blur is Bottom Color. Just make red texture if you don't know what to do.                                                                            |
| ao        | Ambient Occlusion texture for hair. Just make white texture if you don't know what to do.                                                                                                                       |

Do NOT rename texture's name (you can rename extensions) or it will fail to build!

#### Properly name bones

Please follow the bone naming convention to make tool detect target bones and setup dynamic bones and other stuffs automatically.

Root bone should be `***_top`, branch bones should be `***_s`.

It will looks like this

```
hair_top
   ↳ back_s
      ↳ ... child bones
   ↳ front_s
      ↳ ... child bones
   ↳ side_s
      ↳ ... child bones
```

### Export Mesh

![](images/export_00.png)

When you're finished with adjusting your mesh, you need to export your mesh to unity editor to use the mesh in the game.

Since illusion does not like default unity export, you need to do few setup before exporting your model to the editor.

enable those options

-   **Bake Anim** → OFF
-   **Export Types** → {Empty, Armature, Mesh, Other}
-   **Scale** → 1
-   **Apply Scalings** → FBX ALL
-   **Forward** → -Z Forward
-   **Up** → Y Up
-   **Apply Unit** → ON
-   **Apply Transform** → ON
-   **Bake Animation** → OFF

if you know how to import / make your own export preset, just copy and paste this option.

```python
import bpy
op = bpy.context.active_operator

op.filepath = 'TARGET PATH NAME'
op.use_selection = True
op.use_active_collection = False
op.global_scale = 1.0
op.apply_unit_scale = True
op.apply_scale_options = 'FBX_SCALE_ALL'
op.bake_space_transform = True
op.object_types = {'MESH', 'ARMATURE', 'OTHER', 'EMPTY'}
op.use_mesh_modifiers = True
op.use_mesh_modifiers_render = True
op.mesh_smooth_type = 'OFF'
op.use_subsurf = False
op.use_mesh_edges = False
op.use_tspace = False
op.use_custom_props = False
op.add_leaf_bones = False
op.primary_bone_axis = 'Y'
op.secondary_bone_axis = 'X'
op.use_armature_deform_only = False
op.armature_nodetype = 'NULL'
op.bake_anim = False
op.bake_anim_use_all_bones = True
op.bake_anim_use_nla_strips = True
op.bake_anim_use_all_actions = True
op.bake_anim_force_startend_keying = True
op.bake_anim_step = 1.0
op.bake_anim_simplify_factor = 1.0
op.path_mode = 'AUTO'
op.embed_textures = False
op.batch_mode = 'OFF'
op.use_batch_own_dir = True
op.axis_forward = '-Z'
op.axis_up = 'Y'
```

## Trouble Shooting

!> If you can't find the issue here, then check [**Trouble Shooting**](tutorials/trouble-shooting.md) page.
