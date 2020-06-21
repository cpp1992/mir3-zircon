﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Libraries
    {
        public static Dictionary<LibraryFile, string> LibraryList = new Dictionary<LibraryFile, string>
        {
            [LibraryFile.Interface1c] = @"Data\Interface1c.Zl",
            [LibraryFile.Interface] = @"Data\Interface.Zl",
            [LibraryFile.GameInter] = @"Data\GameInter.Zl",
            [LibraryFile.Equip] = @"Data\Equip.Zl",
            [LibraryFile.EquipEffect_UI] = @"Data\EquipEffect-UI.Zl",
            [LibraryFile.EquipEffect_Part] = @"Data\EquipEffect-Part.Zl",
            [LibraryFile.ProgUse] = @"Data\ProgUse.Zl",
            [LibraryFile.StoreItems] = @"Data\StoreItems.Zl",
            [LibraryFile.Inventory] = @"Data\Inventory.Zl",
            [LibraryFile.Ground] = @"Data\Ground.Zl",
            [LibraryFile.NPC] = @"Data\NPC.Zl",
            [LibraryFile.GameInter2] = @"Data\GameInter2.Zl",
            [LibraryFile.MiniMap] = @"Data\MiniMap.Zl",
            
            [LibraryFile.MagicIcon] = @"Data\MIcon.Zl",
            [LibraryFile.CBIcon] = @"Data\CBIcons.Zl",

            [LibraryFile.PEquipB1] = @"Data\PEquipB1.Zl",
            [LibraryFile.PEquipH1] = @"Data\PEquipH1.Zl",

            [LibraryFile.M_Hum] = @"Data\M-Hum.Zl",
            [LibraryFile.M_HumEx1] = @"Data\M-HumEx1.Zl",
            [LibraryFile.M_HumEx2] = @"Data\M-HumEx2.Zl",
            [LibraryFile.M_HumEx3] = @"Data\M-HumEx3.Zl",
            [LibraryFile.M_HumEx4] = @"Data\M-HumEx4.Zl",
            [LibraryFile.M_HumEx10] = @"Data\M-HumEx10.Zl",
            [LibraryFile.M_HumEx11] = @"Data\M-HumEx11.Zl",
            [LibraryFile.M_HumEx12] = @"Data\M-HumEx12.Zl",
            [LibraryFile.M_HumEx13] = @"Data\M-HumEx13.Zl",

            [LibraryFile.WM_Hum] = @"Data\WM-Hum.Zl",
            [LibraryFile.WM_HumEx1] = @"Data\WM-HumEx1.Zl",
            [LibraryFile.WM_HumEx2] = @"Data\WM-HumEx2.Zl",
            [LibraryFile.WM_HumEx3] = @"Data\WM-HumEx3.Zl",
            [LibraryFile.WM_HumEx4] = @"Data\WM-HumEx4.Zl",
            [LibraryFile.WM_HumEx10] = @"Data\WM-HumEx10.Zl",
            [LibraryFile.WM_HumEx11] = @"Data\WM-HumEx11.Zl",
            [LibraryFile.WM_HumEx12] = @"Data\WM-HumEx12.Zl",
            [LibraryFile.WM_HumEx13] = @"Data\WM-HumEx13.Zl",

            [LibraryFile.M_Hair] = @"Data\M-Hair.Zl",
            [LibraryFile.WM_Hair] = @"Data\WM-Hair.Zl",

            [LibraryFile.M_HumA] = @"Data\M-HumA.Zl",
            [LibraryFile.M_HumAEx1] = @"Data\M-HumAEx1.Zl",
            [LibraryFile.M_HumAEx2] = @"Data\M-HumAEx2.Zl",
            [LibraryFile.M_HumAEx3] = @"Data\M-HumAEx3.Zl",

            [LibraryFile.WM_HumA] = @"Data\WM-HumA.Zl",
            [LibraryFile.WM_HumAEx1] = @"Data\WM-HumAEx1.Zl",
            [LibraryFile.WM_HumAEx2] = @"Data\WM-HumAEx2.Zl",
            [LibraryFile.WM_HumAEx3] = @"Data\WM-HumAEx3.Zl",

            [LibraryFile.M_HairA] = @"Data\M-HairA.Zl",
            [LibraryFile.WM_HairA] = @"Data\WM-HairA.Zl",

            [LibraryFile.Horse] = @"Data\Horse.Zl",
            [LibraryFile.HorseIron] = @"Data\Horse_Iron.Zl",
            [LibraryFile.HorseSilver] = @"Data\Horse_Silver.Zl",
            [LibraryFile.HorseGold] = @"Data\Horse_Golden.Zl",
            [LibraryFile.HorseBlue] = @"Data\Horse_Blue.Zl",
            [LibraryFile.HorseDark] = @"Data\Horse_Dark.Zl",
            [LibraryFile.HorseDarkEffect] = @"Data\Horse_DarkEffect.Zl",

            [LibraryFile.M_Shield1] = @"Data\M-Shield1.Zl",
            [LibraryFile.M_Shield2] = @"Data\M-Shield2.Zl",
            [LibraryFile.WM_Shield1] = @"Data\WM-Shield1.Zl",
            [LibraryFile.WM_Shield2] = @"Data\WM-Shield2.Zl",

            [LibraryFile.M_Weapon1] = @"Data\M-Weapon1.Zl",
            [LibraryFile.M_Weapon2] = @"Data\M-Weapon2.Zl",
            [LibraryFile.M_Weapon3] = @"Data\M-Weapon3.Zl",
            [LibraryFile.M_Weapon4] = @"Data\M-Weapon4.Zl",
            [LibraryFile.M_Weapon5] = @"Data\M-Weapon5.Zl",
            [LibraryFile.M_Weapon6] = @"Data\M-Weapon6.Zl",
            [LibraryFile.M_Weapon7] = @"Data\M-Weapon7.Zl",
            [LibraryFile.M_Weapon10] = @"Data\M-Weapon10.Zl",
            [LibraryFile.M_Weapon11] = @"Data\M-Weapon11.Zl",
            [LibraryFile.M_Weapon12] = @"Data\M-Weapon12.Zl",
            [LibraryFile.M_Weapon13] = @"Data\M-Weapon13.Zl",
            [LibraryFile.M_Weapon14] = @"Data\M-Weapon14.Zl",
            [LibraryFile.M_Weapon15] = @"Data\M-Weapon15.Zl",
            [LibraryFile.M_Weapon16] = @"Data\M-Weapon16.Zl",
            
            [LibraryFile.WM_Weapon1] = @"Data\WM-Weapon1.Zl",
            [LibraryFile.WM_Weapon2] = @"Data\WM-Weapon2.Zl",
            [LibraryFile.WM_Weapon3] = @"Data\WM-Weapon3.Zl",
            [LibraryFile.WM_Weapon4] = @"Data\WM-Weapon4.Zl",
            [LibraryFile.WM_Weapon5] = @"Data\WM-Weapon5.Zl",
            [LibraryFile.WM_Weapon6] = @"Data\WM-Weapon6.Zl",
            [LibraryFile.WM_Weapon7] = @"Data\WM-Weapon7.Zl",
            [LibraryFile.WM_Weapon10] = @"Data\WM-Weapon10.Zl",
            [LibraryFile.WM_Weapon11] = @"Data\WM-Weapon11.Zl",
            [LibraryFile.WM_Weapon12] = @"Data\WM-Weapon12.Zl",
            [LibraryFile.WM_Weapon13] = @"Data\WM-Weapon13.Zl",
            [LibraryFile.WM_Weapon14] = @"Data\WM-Weapon14.Zl",
            [LibraryFile.WM_Weapon15] = @"Data\WM-Weapon15.Zl",
            [LibraryFile.WM_Weapon16] = @"Data\WM-Weapon16.Zl",



            [LibraryFile.M_WeaponADL1] = @"Data\M-WeaponADL1.Zl",
            [LibraryFile.M_WeaponADL2] = @"Data\M-WeaponADL2.Zl",
            [LibraryFile.M_WeaponADL6] = @"Data\M-WeaponADL6.Zl",
            [LibraryFile.M_WeaponADR1] = @"Data\M-WeaponADR1.Zl",
            [LibraryFile.M_WeaponADR2] = @"Data\M-WeaponADR2.Zl",
            [LibraryFile.M_WeaponADR6] = @"Data\M-WeaponADR6.Zl",

            [LibraryFile.M_WeaponAOH1] = @"Data\M-WeaponAOH1.Zl",
            [LibraryFile.M_WeaponAOH2] = @"Data\M-WeaponAOH2.Zl",
            [LibraryFile.M_WeaponAOH3] = @"Data\M-WeaponAOH3.Zl",
            [LibraryFile.M_WeaponAOH4] = @"Data\M-WeaponAOH4.Zl",
            [LibraryFile.M_WeaponAOH5] = @"Data\WM-WeaponAOH5.Zl",
            [LibraryFile.M_WeaponAOH6] = @"Data\WM-WeaponAOH6.Zl",


            [LibraryFile.WM_WeaponADL1] = @"Data\WM-WeaponADL1.Zl",
            [LibraryFile.WM_WeaponADL2] = @"Data\WM-WeaponADL2.Zl",
            [LibraryFile.WM_WeaponADL6] = @"Data\WM-WeaponADL6.Zl",
            [LibraryFile.WM_WeaponADR1] = @"Data\WM-WeaponADR1.Zl",
            [LibraryFile.WM_WeaponADR2] = @"Data\WM-WeaponADR2.Zl",
            [LibraryFile.WM_WeaponADR6] = @"Data\WM-WeaponADR6.Zl",

            [LibraryFile.WM_WeaponAOH1] = @"Data\WM-WeaponAOH1.Zl",
            [LibraryFile.WM_WeaponAOH2] = @"Data\WM-WeaponAOH2.Zl",
            [LibraryFile.WM_WeaponAOH3] = @"Data\WM-WeaponAOH3.Zl",
            [LibraryFile.WM_WeaponAOH4] = @"Data\WM-WeaponAOH4.Zl",
            [LibraryFile.WM_WeaponAOH5] = @"Data\WWM-WeaponAOH5.Zl",
            [LibraryFile.WM_WeaponAOH6] = @"Data\WWM-WeaponAOH6.Zl",


            [LibraryFile.M_Helmet1] = @"Data\M-Helmet1.Zl",
            [LibraryFile.M_Helmet2] = @"Data\M-Helmet2.Zl",
            [LibraryFile.M_Helmet3] = @"Data\M-Helmet3.Zl",
            [LibraryFile.M_Helmet4] = @"Data\M-Helmet4.Zl",
            [LibraryFile.M_Helmet5] = @"Data\M-Helmet5.Zl",
            
            [LibraryFile.M_Helmet11] = @"Data\M-Helmet11.Zl",
            [LibraryFile.M_Helmet12] = @"Data\M-Helmet12.Zl",
            [LibraryFile.M_Helmet13] = @"Data\M-Helmet13.Zl",
            [LibraryFile.M_Helmet14] = @"Data\M-Helmet14.Zl",


            [LibraryFile.WM_Helmet1] = @"Data\WM-Helmet1.Zl",
            [LibraryFile.WM_Helmet2] = @"Data\WM-Helmet2.Zl",
            [LibraryFile.WM_Helmet3] = @"Data\WM-Helmet3.Zl",
            [LibraryFile.WM_Helmet4] = @"Data\WM-Helmet4.Zl",
            [LibraryFile.WM_Helmet5] = @"Data\WM-Helmet5.Zl",

            [LibraryFile.WM_Helmet11] = @"Data\WM-Helmet11.Zl",
            [LibraryFile.WM_Helmet12] = @"Data\WM-Helmet12.Zl",
            [LibraryFile.WM_Helmet13] = @"Data\WM-Helmet13.Zl",
            [LibraryFile.WM_Helmet14] = @"Data\WM-Helmet14.Zl",


            [LibraryFile.M_HelmetA1] = @"Data\M-HelmetA1.Zl",
            [LibraryFile.M_HelmetA2] = @"Data\M-HelmetA2.Zl",
            [LibraryFile.M_HelmetA3] = @"Data\M-HelmetA3.Zl",
            [LibraryFile.M_HelmetA4] = @"Data\M-HelmetA4.Zl",


            [LibraryFile.WM_HelmetA1] = @"Data\WM-HelmetA1.Zl",
            [LibraryFile.WM_HelmetA2] = @"Data\WM-HelmetA2.Zl",
            [LibraryFile.WM_HelmetA3] = @"Data\WM-HelmetA3.Zl",
            [LibraryFile.WM_HelmetA4] = @"Data\WM-HelmetA4.Zl",



            [LibraryFile.MonMagic] = @"Data\MonMagic.Zl", //
            [LibraryFile.MonMagicEx] = @"Data\MonMagicEx.Zl", //
            [LibraryFile.MonMagicEx2] = @"Data\MonMagicEx2.Zl", //
            [LibraryFile.MonMagicEx3] = @"Data\MonMagicEx3.Zl", //
            [LibraryFile.MonMagicEx4] = @"Data\MonMagicEx4.Zl", //
            [LibraryFile.MonMagicEx5] = @"Data\MonMagicEx5.Zl", //
            [LibraryFile.MonMagicEx6] = @"Data\MonMagicEx6.Zl", //
            [LibraryFile.MonMagicEx7] = @"Data\MonMagicEx7.Zl", //
            [LibraryFile.MonMagicEx8] = @"Data\MonMagicEx8.Zl", //
            [LibraryFile.MonMagicEx9] = @"Data\MonMagicEx9.Zl", //
            [LibraryFile.MonMagicEx19] = @"Data\MonMagicEx19.Zl", //
            [LibraryFile.MonMagicEx20] = @"Data\MonMagicEx20.Zl", //
            [LibraryFile.MonMagicEx21] = @"Data\MonMagicEx21.Zl", //
            [LibraryFile.MonMagicEx22] = @"Data\MonMagicEx22.Zl", //
            [LibraryFile.MonMagicEx23] = @"Data\MonMagicEx23.Zl", //
            [LibraryFile.MonMagicEx26] = @"Data\MonMagicEx26.Zl", //

            [LibraryFile.Mon_1] = @"Data\Mon-1.Zl",
            [LibraryFile.Mon_2] = @"Data\Mon-2.Zl",
            [LibraryFile.Mon_3] = @"Data\Mon-3.Zl",
            [LibraryFile.Mon_4] = @"Data\Mon-4.Zl",
            [LibraryFile.Mon_5] = @"Data\Mon-5.Zl",
            [LibraryFile.Mon_6] = @"Data\Mon-6.Zl",
            [LibraryFile.Mon_7] = @"Data\Mon-7.Zl",
            [LibraryFile.Mon_8] = @"Data\Mon-8.Zl",
            [LibraryFile.Mon_9] = @"Data\Mon-9.Zl",
            [LibraryFile.Mon_10] = @"Data\Mon-10.Zl",

            [LibraryFile.Mon_11] = @"Data\Mon-11.Zl",
            [LibraryFile.Mon_12] = @"Data\Mon-12.Zl",
            [LibraryFile.Mon_13] = @"Data\Mon-13.Zl",
            [LibraryFile.Mon_14] = @"Data\Mon-14.Zl",
            [LibraryFile.Mon_15] = @"Data\Mon-15.Zl",
            [LibraryFile.Mon_16] = @"Data\Mon-16.Zl",
            [LibraryFile.Mon_17] = @"Data\Mon-17.Zl",
            [LibraryFile.Mon_18] = @"Data\Mon-18.Zl",
            [LibraryFile.Mon_19] = @"Data\Mon-19.Zl",
            [LibraryFile.Mon_20] = @"Data\Mon-20.Zl",

            [LibraryFile.Mon_21] = @"Data\Mon-21.Zl",
            [LibraryFile.Mon_22] = @"Data\Mon-22.Zl",
            [LibraryFile.Mon_23] = @"Data\Mon-23.Zl",
            [LibraryFile.Mon_24] = @"Data\Mon-24.Zl",
            [LibraryFile.Mon_25] = @"Data\Mon-25.Zl",
            [LibraryFile.Mon_26] = @"Data\Mon-26.Zl",
            [LibraryFile.Mon_27] = @"Data\Mon-27.Zl",
            [LibraryFile.Mon_28] = @"Data\Mon-28.Zl",
            [LibraryFile.Mon_29] = @"Data\Mon-29.Zl",
            [LibraryFile.Mon_30] = @"Data\Mon-30.Zl",

            [LibraryFile.Mon_31] = @"Data\Mon-31.Zl",
            [LibraryFile.Mon_32] = @"Data\Mon-32.Zl",
            [LibraryFile.Mon_33] = @"Data\Mon-33.Zl",
            [LibraryFile.Mon_34] = @"Data\Mon-34.Zl",
            [LibraryFile.Mon_35] = @"Data\Mon-35.Zl",
            [LibraryFile.Mon_36] = @"Data\Mon-36.Zl",
            [LibraryFile.Mon_37] = @"Data\Mon-37.Zl",
            [LibraryFile.Mon_38] = @"Data\Mon-38.Zl",
            [LibraryFile.Mon_39] = @"Data\Mon-39.Zl",
            [LibraryFile.Mon_40] = @"Data\Mon-40.Zl",

            [LibraryFile.Mon_41] = @"Data\Mon-41.Zl",
            [LibraryFile.Mon_42] = @"Data\Mon-42.Zl",
            [LibraryFile.Mon_43] = @"Data\Mon-43.Zl",
            [LibraryFile.Mon_44] = @"Data\Mon-44.Zl",
            [LibraryFile.Mon_45] = @"Data\Mon-45.Zl",
            [LibraryFile.Mon_46] = @"Data\Mon-46.Zl",
            [LibraryFile.Mon_47] = @"Data\Mon-47.Zl",
            [LibraryFile.Mon_48] = @"Data\Mon-48.Zl",
            [LibraryFile.Mon_49] = @"Data\Mon-49.Zl",
            [LibraryFile.Mon_50] = @"Data\Mon-50.Zl",

            [LibraryFile.Mon_51] = @"Data\Mon-51.Zl",
            [LibraryFile.Mon_52] = @"Data\Mon-52.Zl",
            [LibraryFile.Mon_53] = @"Data\Mon-53.Zl",
            [LibraryFile.Mon_54] = @"Data\Mon-54.Zl",
            [LibraryFile.Mon_55] = @"Data\Mon-55.Zl",
            [LibraryFile.Mon_56] = @"Data\Mon-56.Zl",
            
            [LibraryFile.Magic] = @"Data\Magic.Zl",
            [LibraryFile.MagicEx] = @"Data\MagicEx.Zl",
            [LibraryFile.MagicEx2] = @"Data\MagicEx2.Zl",
            [LibraryFile.MagicEx3] = @"Data\MagicEx3.Zl",
            [LibraryFile.MagicEx4] = @"Data\MagicEx4.Zl",
            [LibraryFile.MagicEx5] = @"Data\MagicEx5.Zl",
            [LibraryFile.MagicEx6] = @"Data\MagicEx6.Zl",
            [LibraryFile.MagicEx7] = @"Data\MagicEx7.Zl",
            [LibraryFile.MagicEx8] = @"Data\MagicEx8.Zl",
            [LibraryFile.MagicEx9] = @"Data\MagicEx9.Zl",
            
            [LibraryFile.Animationsc] = @"Data\Map Data\Animationsc.Zl",
            [LibraryFile.Cliffsc] = @"Data\Map Data\Cliffsc.Zl",
            [LibraryFile.Dungeonsc] = @"Data\Map Data\Dungeonsc.Zl",
            [LibraryFile.Furnituresc] = @"Data\Map Data\Furnituresc.Zl",
            [LibraryFile.Housesc] = @"Data\Map Data\Housesc.Zl",
            [LibraryFile.Innersc] = @"Data\Map Data\Innersc.Zl",
            [LibraryFile.Object1c] = @"Data\Map Data\Object1c.Zl",
            [LibraryFile.Object2c] = @"Data\Map Data\Object2c.Zl",
            [LibraryFile.SmObjectsc] = @"Data\Map Data\SmObjectsc.Zl",
            [LibraryFile.SmTilesc] = @"Data\Map Data\SmTilesc.Zl",
            [LibraryFile.Tiles5c] = @"Data\Map Data\Tiles5c.Zl",
            [LibraryFile.Tiles30c] = @"Data\Map Data\Tiles30c.Zl",
            [LibraryFile.Tilesc] = @"Data\Map Data\Tilesc.Zl",
            [LibraryFile.Wallsc] = @"Data\Map Data\Wallsc.Zl",

            [LibraryFile.Forest_Animationsc] = @"Data\Map Data\Forest\Animationsc.Zl",
            [LibraryFile.Forest_Cliffsc] = @"Data\Map Data\Forest\Cliffsc.Zl",
            [LibraryFile.Forest_Dungeonsc] = @"Data\Map Data\Forest\Dungeonsc.Zl",
            [LibraryFile.Forest_Furnituresc] = @"Data\Map Data\Forest\Furnituresc.Zl",
            [LibraryFile.Forest_Housesc] = @"Data\Map Data\Forest\Housesc.Zl",
            [LibraryFile.Forest_Innersc] = @"Data\Map Data\Forest\Innersc.Zl",
            [LibraryFile.Forest_SmObjectsc] = @"Data\Map Data\Forest\SmObjectsc.Zl",
            [LibraryFile.Forest_SmTilesc] = @"Data\Map Data\Forest\SmTilesc.Zl",
            [LibraryFile.Forest_Tiles5c] = @"Data\Map Data\Forest\Tiles5c.Zl",
            [LibraryFile.Forest_Tiles30c] = @"Data\Map Data\Forest\Tiles30c.Zl",
            [LibraryFile.Forest_Tilesc] = @"Data\Map Data\Forest\Tilesc.Zl",
            [LibraryFile.Forest_Wallsc] = @"Data\Map Data\Forest\Wallsc.Zl",

            [LibraryFile.Sand_Animationsc] = @"Data\Map Data\Sand\Animationsc.Zl",
            [LibraryFile.Sand_Cliffsc] = @"Data\Map Data\Sand\Cliffsc.Zl",
            [LibraryFile.Sand_Dungeonsc] = @"Data\Map Data\Sand\Dungeonsc.Zl",
            [LibraryFile.Sand_Furnituresc] = @"Data\Map Data\Sand\Furnituresc.Zl",
            [LibraryFile.Sand_Housesc] = @"Data\Map Data\Sand\Housesc.Zl",
            [LibraryFile.Sand_Innersc] = @"Data\Map Data\Sand\Innersc.Zl",
            [LibraryFile.Sand_SmObjectsc] = @"Data\Map Data\Sand\SmObjectsc.Zl",
            [LibraryFile.Sand_SmTilesc] = @"Data\Map Data\Sand\SmTilesc.Zl",
            [LibraryFile.Sand_Tiles5c] = @"Data\Map Data\Sand\Tiles5c.Zl",
            [LibraryFile.Sand_Tiles30c] = @"Data\Map Data\Sand\Tiles30c.Zl",
            [LibraryFile.Sand_Tilesc] = @"Data\Map Data\Sand\Tilesc.Zl",
            [LibraryFile.Sand_Wallsc] = @"Data\Map Data\Sand\Wallsc.Zl",

            [LibraryFile.Snow_Animationsc] = @"Data\Map Data\Snow\Animationsc.Zl",
            [LibraryFile.Snow_Cliffsc] = @"Data\Map Data\Snow\Cliffsc.Zl",
            [LibraryFile.Snow_Dungeonsc] = @"Data\Map Data\Snow\Dungeonsc.Zl",
            [LibraryFile.Snow_Furnituresc] = @"Data\Map Data\Snow\Furnituresc.Zl",
            [LibraryFile.Snow_Housesc] = @"Data\Map Data\Snow\Housesc.Zl",
            [LibraryFile.Snow_Innersc] = @"Data\Map Data\Snow\Innersc.Zl",
            [LibraryFile.Snow_SmObjectsc] = @"Data\Map Data\Snow\SmObjectsc.Zl",
            [LibraryFile.Snow_SmTilesc] = @"Data\Map Data\Snow\SmTilesc.Zl",
            [LibraryFile.Snow_Tiles5c] = @"Data\Map Data\Snow\Tiles5c.Zl",
            [LibraryFile.Snow_Tiles30c] = @"Data\Map Data\Snow\Tiles30c.Zl",
            [LibraryFile.Snow_Tilesc] = @"Data\Map Data\Snow\Tilesc.Zl",
            [LibraryFile.Snow_Wallsc] = @"Data\Map Data\Snow\Wallsc.Zl",


            [LibraryFile.Wood_Animationsc] = @"Data\Map Data\Wood\Animationsc.Zl",
            [LibraryFile.Wood_Cliffsc] = @"Data\Map Data\Wood\Cliffsc.Zl",
            [LibraryFile.Wood_Dungeonsc] = @"Data\Map Data\Wood\Dungeonsc.Zl",
            [LibraryFile.Wood_Furnituresc] = @"Data\Map Data\Wood\Furnituresc.Zl",
            [LibraryFile.Wood_Housesc] = @"Data\Map Data\Wood\Housesc.Zl",
            [LibraryFile.Wood_Innersc] = @"Data\Map Data\Wood\Innersc.Zl",
            [LibraryFile.Wood_SmObjectsc] = @"Data\Map Data\Wood\SmObjectsc.Zl",
            [LibraryFile.Wood_SmTilesc] = @"Data\Map Data\Wood\SmTilesc.Zl",
            [LibraryFile.Wood_Tiles5c] = @"Data\Map Data\Wood\Tiles5c.Zl",
            [LibraryFile.Wood_Tiles30c] = @"Data\Map Data\Wood\Tiles30c.Zl",
            [LibraryFile.Wood_Tilesc] = @"Data\Map Data\Wood\Tilesc.Zl",
            [LibraryFile.Wood_Wallsc] = @"Data\Map Data\Wood\Wallsc.Zl",

            [LibraryFile.SmTiles] = @"Data\Map Data\2\SmTiles.Zl",
            [LibraryFile.Tiles] = @"Data\Map Data\2\Tiles.Zl",
            [LibraryFile.Objects] = @"Data\Map Data\2\Objects.Zl",
            [LibraryFile.Objects2] = @"Data\Map Data\2\Objects2.Zl",
            [LibraryFile.Objects3] = @"Data\Map Data\2\Objects3.Zl",
            [LibraryFile.Objects4] = @"Data\Map Data\2\Objects4.Zl",
            [LibraryFile.Objects5] = @"Data\Map Data\2\Objects5.Zl",
            [LibraryFile.Objects6] = @"Data\Map Data\2\Objects6.Zl",
            [LibraryFile.Objects7] = @"Data\Map Data\2\Objects7.Zl",
            [LibraryFile.Objects8] = @"Data\Map Data\2\Objects8.Zl",
            [LibraryFile.Objects9] = @"Data\Map Data\2\Objects9.Zl",
            [LibraryFile.Objects10] = @"Data\Map Data\2\Objects10.Zl",
            [LibraryFile.Objects11] = @"Data\Map Data\2\Objects11.Zl",
            [LibraryFile.Objects12] = @"Data\Map Data\2\Objects12.Zl",
            [LibraryFile.Objects13] = @"Data\Map Data\2\Objects13.Zl",
            [LibraryFile.Objects14] = @"Data\Map Data\2\Objects14.Zl",
            [LibraryFile.Objects15] = @"Data\Map Data\2\Objects15.Zl",
            [LibraryFile.Objects16] = @"Data\Map Data\2\Objects16.Zl",
            [LibraryFile.Objects17] = @"Data\Map Data\2\Objects17.Zl",
            [LibraryFile.Objects18] = @"Data\Map Data\2\Objects18.Zl",
            [LibraryFile.Objects19] = @"Data\Map Data\2\Objects19.Zl",
            [LibraryFile.Objects20] = @"Data\Map Data\2\Objects20.Zl",
            [LibraryFile.Objects21] = @"Data\Map Data\2\Objects21.Zl",
            [LibraryFile.Objects22] = @"Data\Map Data\2\Objects22.Zl",
            [LibraryFile.Objects23] = @"Data\Map Data\2\Objects23.Zl",
        };

        public static Dictionary<int, LibraryFile> Mir2Order = new Dictionary<int, LibraryFile>
        {
            [0] = LibraryFile.Tiles,
            [1] = LibraryFile.SmTiles,
            [2] = LibraryFile.Objects,
            [3] = LibraryFile.Objects2,
            [4] = LibraryFile.Objects3,
            [5] = LibraryFile.Objects4,
            [6] = LibraryFile.Objects5,
            [7] = LibraryFile.Objects6,
            [8] = LibraryFile.Objects7,
            [9] = LibraryFile.Objects8,
            [10] = LibraryFile.Objects9,
            [11] = LibraryFile.Objects10,
            [12] = LibraryFile.Objects11,
            [13] = LibraryFile.Objects12,
            [14] = LibraryFile.Objects13,
            [15] = LibraryFile.Objects14,
            [16] = LibraryFile.Objects15,
            [17] = LibraryFile.Objects16,
            [18] = LibraryFile.Objects17,
            [19] = LibraryFile.Objects18,
            [20] = LibraryFile.Objects19,
            [21] = LibraryFile.Objects20,
            [22] = LibraryFile.Objects21,
            [23] = LibraryFile.Objects22,
            [24] = LibraryFile.Objects23,
        };

        public static Dictionary<int, LibraryFile> KROrder = new Dictionary<int, LibraryFile>
        {
            [0] = LibraryFile.Tilesc,
            [1] = LibraryFile.Tiles30c,
            [2] = LibraryFile.Tiles5c,
            [3] = LibraryFile.SmTilesc,
            [4] = LibraryFile.Housesc,
            [5] = LibraryFile.Cliffsc,
            [6] = LibraryFile.Dungeonsc,
            [7] = LibraryFile.Innersc,
            [8] = LibraryFile.Furnituresc,
            [9] = LibraryFile.Wallsc,
            [10] = LibraryFile.SmObjectsc,
            [11] = LibraryFile.Animationsc,
            [12] = LibraryFile.Object1c,
            [13] = LibraryFile.Object2c,


            [15] = LibraryFile.Wood_Tilesc,
            [16] = LibraryFile.Wood_Tiles30c,
            [17] = LibraryFile.Wood_Tiles5c,
            [18] = LibraryFile.Wood_SmTilesc,
            [19] = LibraryFile.Wood_Housesc,
            [20] = LibraryFile.Wood_Cliffsc,
            [21] = LibraryFile.Wood_Dungeonsc,
            [22] = LibraryFile.Wood_Innersc,
            [23] = LibraryFile.Wood_Furnituresc,
            [24] = LibraryFile.Wood_Wallsc,
            [25] = LibraryFile.Wood_SmObjectsc,
            [26] = LibraryFile.Wood_Animationsc,


            [30] = LibraryFile.Sand_Tilesc,
            [31] = LibraryFile.Sand_Tiles30c,
            [32] = LibraryFile.Sand_Tiles5c,
            [33] = LibraryFile.Sand_SmTilesc,
            [34] = LibraryFile.Sand_Housesc,
            [35] = LibraryFile.Sand_Cliffsc,
            [36] = LibraryFile.Sand_Dungeonsc,
            [37] = LibraryFile.Sand_Innersc,
            [38] = LibraryFile.Sand_Furnituresc,
            [39] = LibraryFile.Sand_Wallsc,
            [40] = LibraryFile.Sand_SmObjectsc,
            [41] = LibraryFile.Sand_Animationsc,


            [45] = LibraryFile.Snow_Tilesc,
            [46] = LibraryFile.Snow_Tiles30c,
            [47] = LibraryFile.Snow_Tiles5c,
            [48] = LibraryFile.Snow_SmTilesc,
            [49] = LibraryFile.Snow_Housesc,
            [50] = LibraryFile.Snow_Cliffsc,
            [51] = LibraryFile.Snow_Dungeonsc,
            [52] = LibraryFile.Snow_Innersc,
            [53] = LibraryFile.Snow_Furnituresc,
            [54] = LibraryFile.Snow_Wallsc,
            [55] = LibraryFile.Snow_SmObjectsc,
            [56] = LibraryFile.Snow_Animationsc,


            [60] = LibraryFile.Forest_Tilesc,
            [61] = LibraryFile.Forest_Tiles30c,
            [62] = LibraryFile.Forest_Tiles5c,
            [63] = LibraryFile.Forest_SmTilesc,
            [64] = LibraryFile.Forest_Housesc,
            [65] = LibraryFile.Forest_Cliffsc,
            [66] = LibraryFile.Forest_Dungeonsc,
            [67] = LibraryFile.Forest_Innersc,
            [68] = LibraryFile.Forest_Furnituresc,
            [69] = LibraryFile.Forest_Wallsc,
            [70] = LibraryFile.Forest_SmObjectsc,
            [71] = LibraryFile.Forest_Animationsc,
        };
    }

    public enum LibraryFile
    {
        None,

        Interface1c,
        Interface,
        GameInter,
        GameInter2,
        Equip,
        EquipEffect_UI,
        EquipEffect_Part,
        ProgUse,
        StoreItems,
        Inventory,
        Ground,
        NPC,
        MiniMap,
        MagicIcon,
        CBIcon,

        PEquipB1,
        PEquipH1,

        M_Hum,
        M_HumEx1,
        M_HumEx2,
        M_HumEx3,
        M_HumEx4,
        M_HumEx10,
        M_HumEx11,
        M_HumEx12,
        M_HumEx13,
        M_Hair,

        WM_Hum,
        WM_HumEx1,
        WM_HumEx2,
        WM_HumEx3,
        WM_HumEx4,
        WM_HumEx10,
        WM_HumEx11,
        WM_HumEx12,
        WM_HumEx13,
        WM_Hair,

        M_HumA,
        M_HumAEx1,
        M_HumAEx2,
        M_HumAEx3,
        M_HairA,

        WM_HumA,
        WM_HumAEx1,
        WM_HumAEx2,
        WM_HumAEx3,
        WM_HairA,

        Horse,

        HorseIron,
        HorseSilver,
        HorseGold,
        HorseBlue,
        HorseDark,
        HorseDarkEffect,


        M_Weapon1,
        M_Weapon2,
        M_Weapon3,
        M_Weapon4,
        M_Weapon5,
        M_Weapon6,
        M_Weapon7,
        M_Weapon10,
        M_Weapon11,
        M_Weapon12,
        M_Weapon13,
        M_Weapon14,
        M_Weapon15,
        M_Weapon16,

        WM_Weapon1,
        WM_Weapon2,
        WM_Weapon3,
        WM_Weapon4,
        WM_Weapon5,
        WM_Weapon6,
        WM_Weapon7,
        WM_Weapon10,
        WM_Weapon11,
        WM_Weapon12,
        WM_Weapon13,
        WM_Weapon14,
        WM_Weapon15,
        WM_Weapon16,

        M_WeaponADL1,
        M_WeaponADL2,
        M_WeaponADL6,
        M_WeaponADR1,
        M_WeaponADR2,
        M_WeaponADR6,

        M_WeaponAOH1,
        M_WeaponAOH2,
        M_WeaponAOH3,
        M_WeaponAOH4,
        M_WeaponAOH5,
        M_WeaponAOH6,

        WM_WeaponADL1,
        WM_WeaponADL2,
        WM_WeaponADL6,
        WM_WeaponADR1,
        WM_WeaponADR2,
        WM_WeaponADR6,

        WM_WeaponAOH1,
        WM_WeaponAOH2,
        WM_WeaponAOH3,
        WM_WeaponAOH4,
        WM_WeaponAOH5,
        WM_WeaponAOH6,

        M_Shield1,
        M_Shield2,

        WM_Shield1,
        WM_Shield2,

        M_Helmet1,
        M_Helmet2,
        M_Helmet3,
        M_Helmet4,
        M_Helmet5,

        M_Helmet11,
        M_Helmet12,
        M_Helmet13,
        M_Helmet14,

        WM_Helmet1,
        WM_Helmet2,
        WM_Helmet3,
        WM_Helmet4,
        WM_Helmet5,

        WM_Helmet11,
        WM_Helmet12,
        WM_Helmet13,
        WM_Helmet14,
        
        M_HelmetA1,
        M_HelmetA2,
        M_HelmetA3,
        M_HelmetA4,

        WM_HelmetA1,
        WM_HelmetA2,
        WM_HelmetA3,
        WM_HelmetA4,

        MonMagic,
        MonMagicEx,
        MonMagicEx2,
        MonMagicEx3,
        MonMagicEx4,
        MonMagicEx5,
        MonMagicEx6,
        MonMagicEx7,
        MonMagicEx8,
        MonMagicEx9,
        MonMagicEx19,
        MonMagicEx20,
        MonMagicEx21,
        MonMagicEx22,
        MonMagicEx23,
        MonMagicEx26,

        Mon_1,
        Mon_2,
        Mon_3,
        Mon_4,
        Mon_5,
        Mon_6,
        Mon_7,
        Mon_8,
        Mon_9,
        Mon_10,

        Mon_11,
        Mon_12,
        Mon_13,
        Mon_14,
        Mon_15,
        Mon_16,
        Mon_17,
        Mon_18,
        Mon_19,
        Mon_20,

        Mon_21,
        Mon_22,
        Mon_23,
        Mon_24,
        Mon_25,
        Mon_26,
        Mon_27,
        Mon_28,
        Mon_29,
        Mon_30,

        Mon_31,
        Mon_32,
        Mon_33,
        Mon_34,
        Mon_35,
        Mon_36,
        Mon_37,
        Mon_38,
        Mon_39,
        Mon_40,

        Mon_41,
        Mon_42,
        Mon_43,
        Mon_44,
        Mon_45,
        Mon_46,
        Mon_47,
        Mon_48,
        Mon_49,
        Mon_50,

        Mon_51,
        Mon_52,
        Mon_53,
        Mon_54,
        Mon_55,
        Mon_56,


        Magic, 
        MagicEx,
        MagicEx2,
        MagicEx3,
        MagicEx4,
        MagicEx5,
        MagicEx6,
        MagicEx7,
        MagicEx8,
        MagicEx9,

        Animationsc,
        Cliffsc,
        Dungeonsc,
        Furnituresc,
        Housesc,
        Innersc,
        Object1c,
        Object2c,
        SmObjectsc,
        SmTilesc,
        Tiles5c,
        Tiles30c,
        Tilesc,
        Wallsc,

        Forest_Animationsc,
        Forest_Cliffsc,
        Forest_Dungeonsc,
        Forest_Furnituresc,
        Forest_Housesc,
        Forest_Innersc,
        Forest_SmObjectsc,
        Forest_SmTilesc,
        Forest_Tiles5c,
        Forest_Tiles30c,
        Forest_Tilesc,
        Forest_Wallsc,

        Sand_Animationsc,
        Sand_Cliffsc,
        Sand_Dungeonsc,
        Sand_Furnituresc,
        Sand_Housesc,
        Sand_Innersc,
        Sand_SmObjectsc,
        Sand_SmTilesc,
        Sand_Tiles5c,
        Sand_Tiles30c,
        Sand_Tilesc,
        Sand_Wallsc,

        Snow_Animationsc,
        Snow_Cliffsc,
        Snow_Dungeonsc,
        Snow_Furnituresc,
        Snow_Housesc,
        Snow_Innersc,
        Snow_SmObjectsc,
        Snow_SmTilesc,
        Snow_Tiles5c,
        Snow_Tiles30c,
        Snow_Tilesc,
        Snow_Wallsc,

        Wood_Animationsc,
        Wood_Cliffsc,
        Wood_Dungeonsc,
        Wood_Furnituresc,
        Wood_Housesc,
        Wood_Innersc,
        Wood_SmObjectsc,
        Wood_SmTilesc,
        Wood_Tiles5c,
        Wood_Tiles30c,
        Wood_Tilesc,
        Wood_Wallsc,

        Tiles,
        SmTiles,
        Objects,
        Objects2,
        Objects3,
        Objects4,
        Objects5,
        Objects6,
        Objects7,
        Objects8,
        Objects9,
        Objects10,
        Objects11,
        Objects12,
        Objects13,
        Objects14,
        Objects15,
        Objects16,
        Objects17,
        Objects18,
        Objects19,
        Objects20,
        Objects21,
        Objects22,
        Objects23,
    }
}
