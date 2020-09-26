# Known ILLUSION Standards

## Common

### Generic

-   All of game data is serialized to `ResourceManager` MonoBehavior.
    That is perfect entry to find all of assets what game is referencing from.
-   The texture coloring and pattern is rendered with Render Target Texture and shader.

### ADV

-   ADV system is one of the system ILLUSION uses for generic events in the game.
-   It has it's own variable system. So trying to find any main-game related variable in the code base is not going to work.
-   You can check detailed list of ADV Command List for those games in these Documents below:

    -   [Honey Select 2 : Libido ADV Information](technical/adv-hs2.md)
    -   [AI-Shoujyo ADV Information](technical/adv-ai.md)

## Honey Select 2

-   HS2 is utilizing `ScriptedObject` more than previous game "AI-Shoujyo"

## AI-Shoujyo
