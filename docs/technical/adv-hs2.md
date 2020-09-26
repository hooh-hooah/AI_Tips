# ADV System of Honey Select 2 : Libido

## Special ADV Values

-   `MapName`

    -   Location: `ADVMainScene.cs:69`
    -   Assign Code:
        ```csharp
        packData.MapName = BaseMap.ConvertMapName(game.MapNo);
        ```

-   `EventCGName`

    -   Location: `ADVMainScene.cs:70`
    -   Assign Code:
        ```csharp
        packData.EventCGName = BaseMap.ConvertMapNameEnglish(game.mapNo) + "_Event" + instance.advDelivery.adv_category.ToString("00");
        ```

-   `EventCGBundle`

    -   Location: `ADVMainScene.cs:75-82`
    -   Assign Code:

        ```csharp

        List<string> list = GlobalMethod.GetAssetBundleNameListFromPath("adv/eventcg/")
            .Select(x => x).OrderByDescending(x => x).ToList();

        //...

        packData.EventCGBundle = string.Empty;

        foreach (string text in list)
        {
          if (AssetBundleCheck.GetAllAssetName(text, false, null, false).Contains(packData.EventCGName))
          {
            packData.EventCGBundle = text;
            break;
          }
        }
        ```

-   `JumpAnalAndPain`

    -   Location: `ADVMainScene.cs:83`
    -   Assign Code:

        ```csharp
        packData.JumpAnalAndPain = GlobalHS2Calc.AnalAndPain(chaFileGameInfo);
        ```

-   `isConciergeAngry`
    -   Location: `ADVMainScene.cs:84`
    -   Assign Code:
        ```csharp
        packData.isConciergeAngry = game.isConciergeAngry;
        ```
-   `isParent`
    -   Location: `ADVMainScene.cs:86`
    -   Assign Code:
        ```csharp
        packData.isParent = true
        ```
-   `onComplete`
    -   Location: `ADVMainScene.cs:87`
    -   Assign Code:
        ```csharp
        packData.onComplete += ADVComplete
        ```

## Commonly Used Practice

-   `EventCGSetting,EventCGBundle,EventCGName`

    Generic EventCG Bundle Event.

## ADV Command List

| ID  | Name                     | Description                                      | Arguments                                    |
| --- | ------------------------ | ------------------------------------------------ | -------------------------------------------- |
| 000 | None                     | It does nothing                                  |
| 001 | VAR                      | Sets veriable to key with given argument         | Type, Variable, Value                        |
| 002 | RandomVarF               | Unused Variable                                  |
| 003 | Calc                     | Unknown                                          | Answer, Formula, Value                       |
| 004 | Clamp                    | Unknown                                          |
| 005 | Min                      | Unknown                                          |
| 006 | Max                      | Unknown                                          |
| 007 | Lerp                     | Unknown                                          |
| 008 | LerpAngle                | Unknown                                          |
| 009 | InverseLerp              | Unknown                                          |
| 010 | LerpV3                   | Unknown                                          |
| 011 | LerpAngleV3              | Unknown                                          |
| 012 | Tag                      | Unknown                                          |
| 013 | Format                   | Assign to value with given arguments and formats | TargetVariable, FormatString, Variable/Value |
| 014 | IF                       | Unknown                                          |
| 015 | Switch                   | Unknown                                          |
| 016 | Text                     | Unknown                                          |
| 017 | Voice                    | Unknown                                          |
| 018 | Motion                   | Unknown                                          |
| 019 | Expression               | Unknown                                          |
| 020 | ExpressionIcon           | Unknown                                          |
| 021 | Open                     | Unknown                                          |
| 022 | Close                    | Unknown                                          |
| 023 | Jump                     | Unknown                                          |
| 024 | Choice                   | Unknown                                          |
| 025 | Wait                     | Unknown                                          |
| 026 | TextClear                | Unknown                                          |
| 027 | FontColor                | Unknown                                          |
| 028 | WindowActive             | Unknown                                          |
| 029 | WindowImage              | Unknown                                          |
| 030 | Scene                    | Unknown                                          |
| 031 | Regulate                 | Unknown                                          |
| 032 | Replace                  | Unknown                                          |
| 033 | Reset                    | Unknown                                          |
| 034 | Vector                   | Unknown                                          |
| 035 | NullLoad                 | Unknown                                          |
| 036 | NullRelease              | Unknown                                          |
| 037 | NullSet                  | Unknown                                          |
| 038 | BGLoad                   | Unknown                                          |
| 039 | BGRelease                | Unknown                                          |
| 040 | BGVisible                | Unknown                                          |
| 041 | InfoAudioEco             | Unknown                                          |
| 042 | InfoAnimePlay            | Unknown                                          |
| 043 | Fade                     | Unknown                                          |
| 044 | FadeColor                | Unknown                                          |
| 045 | SceneFade                | Unknown                                          |
| 046 | SceneFadeRegulate        | Unknown                                          |
| 047 | FilterImageLoad          | Unknown                                          |
| 048 | FilterImageRelease       | Unknown                                          |
| 049 | EjaculationEffect        | Unknown                                          |
| 050 | EcstacyEffect            | Unknown                                          |
| 051 | EcstacySyncEffect        | Unknown                                          |
| 052 | CrossFade                | Unknown                                          |
| 053 | CameraActive             | Unknown                                          |
| 054 | CameraAspect             | Unknown                                          |
| 055 | CameraChange             | Unknown                                          |
| 056 | CameraDirectionAdd       | Unknown                                          |
| 057 | CameraDirectionSet       | Unknown                                          |
| 058 | CameraLerpNullMove       | Unknown                                          |
| 059 | CameraLerpNullSet        | Unknown                                          |
| 060 | CameraLerpAdd            | Unknown                                          |
| 061 | CameraLerpSet            | Unknown                                          |
| 062 | CameraLerpAnimationAdd   | Unknown                                          |
| 063 | CameraLerpAnimationSet   | Unknown                                          |
| 064 | CameraLerpTargetAdd      | Unknown                                          |
| 065 | CameraLerpTargetSet      | Unknown                                          |
| 066 | CameraPositionAdd        | Unknown                                          |
| 067 | CameraPositionSet        | Unknown                                          |
| 068 | CameraRotationAdd        | Unknown                                          |
| 069 | CameraRotationSet        | Unknown                                          |
| 070 | CameraDefault            | Unknown                                          |
| 071 | CameraParent             | Unknown                                          |
| 072 | CameraNull               | Unknown                                          |
| 073 | CameraTarget             | Unknown                                          |
| 074 | CameraTargetFront        | Unknown                                          |
| 075 | CameraTargetCharacter    | Unknown                                          |
| 076 | CameraReset              | Unknown                                          |
| 077 | CameraLock               | Unknown                                          |
| 078 | CameraGetFov             | Unknown                                          |
| 079 | CameraSetFov             | Unknown                                          |
| 080 | BGMPlay                  | Unknown                                          |
| 081 | BGMStop                  | Unknown                                          |
| 082 | EnvPlay                  | Unknown                                          |
| 083 | EnvStop                  | Unknown                                          |
| 084 | SE2DPlay                 | Unknown                                          |
| 085 | SE2DStop                 | Unknown                                          |
| 086 | SE3DPlay                 | Unknown                                          |
| 087 | SE3DStop                 | Unknown                                          |
| 088 | CharaCreate              | Unknown                                          |
| 089 | CharaFixCreate           | Unknown                                          |
| 090 | CharaMobCreate           | Unknown                                          |
| 091 | CharaDelete              | Unknown                                          |
| 092 | CharaStand               | Unknown                                          |
| 093 | CharaStandFind           | Unknown                                          |
| 094 | CharaPositionAdd         | Unknown                                          |
| 095 | CharaPositionSet         | Unknown                                          |
| 096 | CharaPositionLocalAdd    | Unknown                                          |
| 097 | CharaPositionLocalSet    | Unknown                                          |
| 098 | CharaMotion              | Unknown                                          |
| 099 | CharaMotionDefault       | Unknown                                          |
| 100 | CharaMotionWait          | Unknown                                          |
| 101 | CharaMotionLayerWeight   | Unknown                                          |
| 102 | CharaMotionSetParam      | Unknown                                          |
| 103 | CharaMotionIKSetPartner  | Unknown                                          |
| 104 | CharaExpression          | Unknown                                          |
| 105 | CharaFixEyes             | Unknown                                          |
| 106 | CharaFixMouth            | Unknown                                          |
| 107 | CharaExpressionIcon      | Unknown                                          |
| 108 | CharaGetShape            | Unknown                                          |
| 109 | CharaCoordinate          | Unknown                                          |
| 110 | CharaClothState          | Unknown                                          |
| 111 | CharaSiruState           | Unknown                                          |
| 112 | CharaVoicePlay           | Unknown                                          |
| 113 | CharaVoiceStop           | Unknown                                          |
| 114 | CharaVoiceStopAll        | Unknown                                          |
| 115 | CharaVoiceWait           | Unknown                                          |
| 116 | CharaVoiceWaitAll        | Unknown                                          |
| 117 | CharaLookEyes            | Unknown                                          |
| 118 | CharaLookEyesTarget      | Unknown                                          |
| 119 | CharaLookEyesTargetChara | Unknown                                          |
| 120 | CharaLookNeck            | Unknown                                          |
| 121 | CharaLookNeckTarget      | Unknown                                          |
| 122 | CharaLookNeckTargetChara | Unknown                                          |
| 123 | CharaLookNeckSkip        | Unknown                                          |
| 124 | CharaItemCreate          | Unknown                                          |
| 125 | CharaItemDelete          | Unknown                                          |
| 126 | CharaItemAnime           | Unknown                                          |
| 127 | CharaItemFind            | Unknown                                          |
| 128 | EventCGSetting           | Initialize EventCG Information of current scene  | BundlePath, BundleName                       |
| 129 | EventCGRelease           | Unknown                                          |
| 130 | EventCGNext              | Unknown                                          |
| 131 | ObjectCreate             | Unknown                                          |
| 132 | ObjectLoad               | Unknown                                          |
| 133 | ObjectDelete             | Unknown                                          |
| 134 | ObjectPosition           | Unknown                                          |
| 135 | ObjectRotation           | Unknown                                          |
| 136 | ObjectScale              | Unknown                                          |
| 137 | ObjectParent             | Unknown                                          |
| 138 | ObjectComponent          | Unknown                                          |
| 139 | ObjectAnimeParam         | Unknown                                          |
| 140 | MoviePlay                | Unknown                                          |
| 141 | CharaActive              | Unknown                                          |
| 142 | CharaVisible             | Unknown                                          |
| 143 | CharaColor               | Unknown                                          |
| 144 | CharaParam               | Unknown                                          |
| 145 | CharaChange              | Change active character                          | Character slot ID                            |
| 146 | CharaNameGet             | Unknown                                          |
| 147 | CharaEvent               | Unknown                                          |
| 148 | HeroineCallNameChange    | Unknown                                          |
| 149 | HeroineFinCG             | Unknown                                          |
| 150 | HeroineParam             | Unknown                                          |
| 151 | PlayerParam              | Unknown                                          |
| 152 | CycleChange              | Unknown                                          |
| 153 | WeekChange               | Unknown                                          |
| 154 | MapChange                | Unknown                                          |
| 155 | MapUnload                | Unknown                                          |
| 156 | MapVisible               | Unknown                                          |
| 157 | MapObjectActive          | Unknown                                          |
| 158 | DayTimeChange            | Unknown                                          |
| 159 | GetGatePos               | Unknown                                          |
| 160 | CameraLookAt             | Unknown                                          |
| 161 | MozVisible               | Unknown                                          |
| 162 | LookAtDankonAdd          | Unknown                                          |
| 163 | LookAtDankonRemove       | Unknown                                          |
| 164 | HMotionShakeAdd          | Unknown                                          |
| 165 | HMotionShakeRemove       | Unknown                                          |
| 166 | HitReaction              | Unknown                                          |
| 167 | AddPosture               | Unknown                                          |
| 168 | AddCollider              | Unknown                                          |
| 169 | ColliderSetActive        | Unknown                                          |
| 170 | AddNavMeshAgent          | Unknown                                          |
| 171 | NavMeshAgentSetActive    | Unknown                                          |
| 172 | BundleCheck              | Unknown                                          |
| 173 | CharaPersonal            | Unknown                                          |
| 174 | HNamaOK                  | Unknown                                          |
| 175 | HNamaNG                  | Unknown                                          |
| 176 | CameraShakePos           | Unknown                                          |
| 177 | CameraShakeRot           | Unknown                                          |
| 178 | Prob                     | Unknown                                          |
| 179 | Probs                    | Unknown                                          |
| 180 | FormatVAR                | Unknown                                          |
| 181 | CharaKaraokePlay         | Unknown                                          |
| 182 | CharaKaraokeStop         | Unknown                                          |
| 183 | Task                     | Unknown                                          |
| 184 | TaskWait                 | Unknown                                          |
| 185 | TaskEnd                  | Unknown                                          |
| 186 | ParameterFile            | Unknown                                          |
| 187 | Log                      | Unknown                                          |
| 188 | HSafeDaySet              | Unknown                                          |
| 189 | HDangerDaySet            | Unknown                                          |
| 190 | HeroineWeddingInfo       | Unknown                                          |
| 191 | CameraLightOffset        | Unknown                                          |
| 192 | CharaSetShape            | Unknown                                          |
| 193 | CharaCoordinateChange    | Unknown                                          |
| 194 | CharaShoesChange         | Unknown                                          |
| 195 | CameraAnimeLoad          | Unknown                                          |
| 196 | CameraAnimePlay          | Unknown                                          |
| 197 | CameraAnimeWait          | Unknown                                          |
| 198 | CameraAnimeLayerWeight   | Unknown                                          |
| 199 | CameraAnimeSetParam      | Unknown                                          |
| 200 | CameraAnimeRelease       | Unknown                                          |
| 201 | CameraLightActive        | Unknown                                          |
| 202 | CameraLightAngle         | Unknown                                          |
| 203 | InfoAudio                | Unknown                                          |
| 204 | CharaCreateEmpty         | Unknown                                          |
| 205 | CharaCreateDummy         | Unknown                                          |
| 206 | CharaFixCreateDummy      | Unknown                                          |
| 207 | CharaMobCreateDummy      | Unknown                                          |
| 208 | ReplaceLanguage          | Unknown                                          |
| 209 | SendCommandData          | Unknown                                          |
| 210 | SendCommandDataList      | Unknown                                          |
| 211 | IFVAR                    | Unknown                                          |
| 212 | CreateConcierge          | Unknown                                          |
| 213 | SceneFadeWait            | Unknown                                          |
| 214 | DOFTargetMove            | Unknown                                          |
| 215 | DOFTargetSet             | Unknown                                          |
| 216 | BlurEffect               | Unknown                                          |
| 217 | DOFTarget                | Unknown                                          |
| 218 | SepiaEffect              | Unknown                                          |
| 219 | VarLanguage              | Unknown                                          |
| 220 | TransitionFade           | Unknown                                          |
| 221 | TransitionFadeTexture    | Unknown                                          |
| 222 | SceneFadeColor           | Unknown                                          |
| 223 | SceneFadeTime            | Unknown                                          |
| 224 | MapObjectAnimation       | Unknown                                          |
| 225 | NowLoadingDraw           | Unknown                                          |
| 226 | DOFDefault               | Unknown                                          |
| 227 | WaitAbs                  | Unknown                                          |
| 228 | CharaWet                 | Unknown                                          |
