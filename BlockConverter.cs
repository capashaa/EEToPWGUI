using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PixelPilot.PixelGameClient;
using PixelPilot.PixelGameClient.World.Constants;
namespace EEtoPWGUI
{
    internal class BlockConverter
    {
        //Meh hardcoded blocks damn
        public static Dictionary<int, int> EEtoPW()
        {
            Dictionary<int, int> _blocks = new Dictionary<int, int>();

            #region Action
            //## Action

            //Action gravity
            _blocks.Add(0, (int)PixelBlock.Empty); //Empty
            _blocks.Add(1, (int)PixelBlock.GravityLeft); //gravity_left
            _blocks.Add(2, (int)PixelBlock.GravityUp); //gravity_up
            _blocks.Add(3, (int)PixelBlock.GravityRight); //gravity_right
            _blocks.Add(4, (int)PixelBlock.GravityDot); //gravity_dot
            _blocks.Add(459, (int)PixelBlock.GravitySlowDot); //gravity_slow_dot
            _blocks.Add(1518, (int)PixelBlock.GravityDown); //gravity_down


            //boost
            _blocks.Add(117, (int)PixelBlock.BoostDown); //boost_down
            _blocks.Add(114, (int)PixelBlock.BoostLeft); //boost_left
            _blocks.Add(115, (int)PixelBlock.BoostRight); //boost_right
            _blocks.Add(116, (int)PixelBlock.BoostUp); //boost_up

            //Crown
            _blocks.Add(5, (int)PixelBlock.Crown); //crown

            //Keys
            _blocks.Add(6, (int)PixelBlock.KeyRed); //red
            _blocks.Add(7, (int)PixelBlock.KeyGreen); //green
            _blocks.Add(8, (int)PixelBlock.KeyBlue); //blue

            //Doors
            _blocks.Add(23, (int)PixelBlock.KeyDoorRed); //red
            _blocks.Add(24, (int)PixelBlock.KeyDoorGreen); //green
            _blocks.Add(25, (int)PixelBlock.KeyDoorBlue); //blue

            //Gates
            _blocks.Add(26, (int)PixelBlock.KeyGateRed); //red
            _blocks.Add(27, (int)PixelBlock.KeyGateGreen); //green
            _blocks.Add(28, (int)PixelBlock.KeyGateBlue); //blue

            //Coins
            _blocks.Add(100, (int)PixelBlock.Coin); //coin
            _blocks.Add(101, (int)PixelBlock.BlueCoin); //blue_coin

            //Spawn point
            _blocks.Add(255, (int)PixelBlock.SpawnPoint); //spawn_point

            //Spawn point
            _blocks.Add(360, (int)PixelBlock.Checkpoint); //checkpoint

            //liquids
            _blocks.Add(119, (int)PixelBlock.Water); //water
            _blocks.Add(300, (int)PixelBlock.WaterSurface); //water_surface

            //Fire
            _blocks.Add(368, (int)PixelBlock.Fire); //fire

            //Spike center
            _blocks.Add(1580, (int)PixelBlock.SpikesCenter); //spikes_center
            #endregion

            #region Blocks
            //Basic blocks
            _blocks.Add(9, (int)PixelBlock.BasicGray); //basic_gray
            _blocks.Add(10, (int)PixelBlock.BasicBlue); //basic_blue
            _blocks.Add(11, (int)PixelBlock.BasicMagenta); //basic_magenta
            _blocks.Add(12, (int)PixelBlock.BasicRed); //basic_red
            _blocks.Add(13, (int)PixelBlock.BasicYellow); //basic_yellow
            _blocks.Add(14, (int)PixelBlock.BasicGreen); //basic_green
            _blocks.Add(15, (int)PixelBlock.BasicCyan); //basic_cyan
            _blocks.Add(182, (int)PixelBlock.BasicBlack); //basic_black
            _blocks.Add(1088, (int)PixelBlock.BasicWhite); //basic_white
            _blocks.Add(1018, (int)PixelBlock.BasicOrange); //basic_orange

            //Brick
            _blocks.Add(16, (int)PixelBlock.BricksBrown); //bricks_brown
            _blocks.Add(17, (int)PixelBlock.BricksTeal); //bricks_teal
            _blocks.Add(18, (int)PixelBlock.BricksPurple); //bricks_purple
            _blocks.Add(19, (int)PixelBlock.BricksGreen); //bricks_green
            _blocks.Add(20, (int)PixelBlock.BricksRed); //bricks_red
            _blocks.Add(21, (int)PixelBlock.BricksOlive); //bricks_olive
            _blocks.Add(1023, (int)PixelBlock.BricksBlue); //bricks_blue
            _blocks.Add(1090, (int)PixelBlock.BricksWhite); //bricks_white
            _blocks.Add(1022, (int)PixelBlock.BricksGray); //bricks_gray

            //Beveled
            _blocks.Add(37, (int)PixelBlock.BeveledMagenta); //beveled_magenta
            _blocks.Add(38, (int)PixelBlock.BeveledGreen); //beveled_green
            _blocks.Add(39, (int)PixelBlock.BeveledBlue); //beveled_blue
            _blocks.Add(40, (int)PixelBlock.BeveledRed); //beveled_red
            _blocks.Add(41, (int)PixelBlock.BeveledYellow); //beveled_yellow
            _blocks.Add(42, (int)PixelBlock.BeveledGray); //beveled_gray
            _blocks.Add(1019, (int)PixelBlock.BeveledCyan); //beveled_cyan
            _blocks.Add(1020, (int)PixelBlock.BeveledOrange); //beveled_orange
            _blocks.Add(1021, (int)PixelBlock.BeveledBlack); //beveled_black
            _blocks.Add(1089, (int)PixelBlock.BeveledWhite); //beveled_white

            //Grass
            _blocks.Add(34, (int)PixelBlock.BricksGrassLeftEdge); //bricks_grass_left_edge
            _blocks.Add(35, (int)PixelBlock.BricksGrass); //bricks_grass
            _blocks.Add(36, (int)PixelBlock.BricksGrassRightEdge); //bricks_grass_right_edge

            //Metal
            _blocks.Add(29, (int)PixelBlock.MetalSilver); //metal_silver
            _blocks.Add(30, (int)PixelBlock.MetalCopper); //metal_copper
            _blocks.Add(31, (int)PixelBlock.MetalGold); //metal_gold

            //Generic
            _blocks.Add(22, (int)PixelBlock.HazardStripes); //hazard_stripes
            _blocks.Add(1058, (int)PixelBlock.DarkHazardStripes); //dark_hazard_stripes
            _blocks.Add(32, (int)PixelBlock.FaceBlock); //face_block
            _blocks.Add(1057, (int)PixelBlock.NoFaceBlock); //no_face_block
            _blocks.Add(33, (int)PixelBlock.BlackBlock); //black_block
            _blocks.Add(44, (int)PixelBlock.FullBlackBlock); //full_black_block

            //Factory
            _blocks.Add(45, (int)PixelBlock.FactoryMetalCrate); //factory_metal_crate
            _blocks.Add(46, (int)PixelBlock.FactoryStone); //factory_stone
            _blocks.Add(47, (int)PixelBlock.FactoryWood); //factory_wood
            _blocks.Add(48, (int)PixelBlock.FactoryWoodenCrate); //factory_wooden_crate
            _blocks.Add(49, (int)PixelBlock.FactoryScales); //factory_scales

            //Secret
            _blocks.Add(50, (int)PixelBlock.SecretAppear); //secret_appear
            _blocks.Add(243, (int)PixelBlock.SecretDisappear); //secret_disappear
            _blocks.Add(136, (int)PixelBlock.SecretInvisible); //secret_invisible

            //glass
            _blocks.Add(51, (int)PixelBlock.GlassRed); //glass_red
            _blocks.Add(58, (int)PixelBlock.GlassOrange); //glass_orange
            _blocks.Add(57, (int)PixelBlock.GlassYellow); //glass_yellow
            _blocks.Add(56, (int)PixelBlock.GlassGreen); //glass_green
            _blocks.Add(55, (int)PixelBlock.GlassCyan); //glass_cyan
            _blocks.Add(54, (int)PixelBlock.GlassBlue); //glass_blue
            _blocks.Add(53, (int)PixelBlock.GlassPurple); //glass_purple
            _blocks.Add(52, (int)PixelBlock.GlassMagenta); //glass_magenta

            //minerals
            _blocks.Add(70, (int)PixelBlock.MineralsRed); //minerals_red
            _blocks.Add(76, (int)PixelBlock.MineralsOrange); //minerals_orange
            _blocks.Add(75, (int)PixelBlock.MineralsYellow); //minerals_yellow
            _blocks.Add(74, (int)PixelBlock.MineralsGreen); //minerals_green
            _blocks.Add(73, (int)PixelBlock.MineralsCyan); //minerals_cyan
            _blocks.Add(72, (int)PixelBlock.MineralsBlue); //minerals_blue
            _blocks.Add(71, (int)PixelBlock.MineralsMagenta); //minerals_magenta

            //Sand
            _blocks.Add(59, (int)PixelBlock.BeachSand); //beach_sand

            //candy
            _blocks.Add(60, (int)PixelBlock.CandyPink); //candy_pink
            _blocks.Add(1154, (int)PixelBlock.CandyBlue); //candy_blue

            _blocks.Add(61, (int)PixelBlock.CandyPlatformPink); //candy_platform_pink
            _blocks.Add(62, (int)PixelBlock.CandyPlatformRed); //candy_platform_red
            _blocks.Add(63, (int)PixelBlock.CandyPlatformCyan); //candy_platform_cyan
            _blocks.Add(64, (int)PixelBlock.CandyPlatformGreen); //candy_platform_green

            _blocks.Add(65, (int)PixelBlock.CandyCane); //candy_cane
            _blocks.Add(66, (int)PixelBlock.CandyLicorice); //candy_licorice
            _blocks.Add(67, (int)PixelBlock.CandyChocolate); //candy_chocolate

            //Platforms

            //Scifi platform
            _blocks.Add(89, (int)PixelBlock.CandyPlatformRed); //candy_platform_red
            _blocks.Add(90, (int)PixelBlock.CandyPlatformRed); //candy_platform_red
            _blocks.Add(91, (int)PixelBlock.CandyPlatformRed); //candy_platform_red
            _blocks.Add(1051, (int)PixelBlock.CandyPlatformRed); //candy_platform_red
            _blocks.Add(1164, (int)PixelBlock.CandyPlatformRed); //candy_platform_red
            _blocks.Add(1165, (int)PixelBlock.CandyPlatformRed); //candy_platform_red

            //pirate platform
            _blocks.Add(154, (int)PixelBlock.CandyPlatformRed); //candy_platform_red

            //Dojo
            _blocks.Add(96, (int)PixelBlock.CandyPlatformRed); //candy_platform_red
            _blocks.Add(97, (int)PixelBlock.CandyPlatformRed); //candy_platform_red

            //industrial
            _blocks.Add(146, (int)PixelBlock.CandyPlatformRed); //candy_platform_red

            //Medeivial
            _blocks.Add(158, (int)PixelBlock.CandyPlatformRed); //candy_platform_red

            //Summer 2016
            _blocks.Add(1087, (int)PixelBlock.CandyPlatformRed); //candy_platform_red

            //Garden
            _blocks.Add(1148, (int)PixelBlock.CandyPlatformRed); //candy_platform_red
            _blocks.Add(1149, (int)PixelBlock.CandyPlatformRed); //candy_platform_red

            //Toxic
            _blocks.Add(1150, (int)PixelBlock.CandyPlatformRed); //candy_platform_red
            #endregion

            #region Background
            //## background

            //Bricks
            _blocks.Add(716, (int)PixelBlock.BricksWhiteBg); //bricks_white_bg
            _blocks.Add(646, (int)PixelBlock.BricksGrayBg); //bricks_gray_bg
            _blocks.Add(648, (int)PixelBlock.BricksBlackBg); //bricks_black_bg
            _blocks.Add(511, (int)PixelBlock.BricksRedBg); //bricks_red_bg
            _blocks.Add(507, (int)PixelBlock.BricksBrownBg); //bricks_brown_bg
            _blocks.Add(512, (int)PixelBlock.BricksOliveBg); //bricks_olive_bg
            _blocks.Add(510, (int)PixelBlock.BricksGreenBg); //bricks_green_bg
            _blocks.Add(508, (int)PixelBlock.BricksTealBg); //bricks_teal_bg
            _blocks.Add(647, (int)PixelBlock.BricksBlueBg); //bricks_blue_bg
            _blocks.Add(509, (int)PixelBlock.BricksPurpleBg); //bricks_purple_bg

            //Basic
            _blocks.Add(715, (int)PixelBlock.BasicWhiteBg); //basic_white_bg
            _blocks.Add(500, (int)PixelBlock.BasicGrayBg); //basic_gray_bg
            _blocks.Add(645, (int)PixelBlock.BasicBlackBg); //basic_black_bg
            _blocks.Add(644, (int)PixelBlock.BasicOrangeBg); //basic_orange_bg
            _blocks.Add(503, (int)PixelBlock.BasicRedBg); //basic_red_bg
            _blocks.Add(504, (int)PixelBlock.BasicYellowBg); //basic_yellow_bg
            _blocks.Add(505, (int)PixelBlock.BasicGreenBg); //basic_green_bg
            _blocks.Add(506, (int)PixelBlock.BasicCyanBg); //basic_cyan_bg
            _blocks.Add(501, (int)PixelBlock.BasicBlueBg); //basic_blue_bg
            _blocks.Add(502, (int)PixelBlock.BasicMagentaBg); //basic_magenta_bg

            //Normal
            _blocks.Add(717, (int)PixelBlock.NormalWhiteBg); //normal_white_bg
            _blocks.Add(610, (int)PixelBlock.NormalGrayBg); //normal_gray_bg
            _blocks.Add(654, (int)PixelBlock.NormalBlackBg); //normal_black_bg
            _blocks.Add(613, (int)PixelBlock.NormalRedBg); //normal_red_bg
            _blocks.Add(653, (int)PixelBlock.NormalOrangeBg); //normal_orange_bg
            _blocks.Add(614, (int)PixelBlock.NormalYellowBg); //normal_yellow_bg
            _blocks.Add(615, (int)PixelBlock.NormalGreenBg); //normal_green_bg
            _blocks.Add(616, (int)PixelBlock.NormalCyanBg); //normal_cyan_bg
            _blocks.Add(611, (int)PixelBlock.NormalBlueBg); //normal_blue_bg
            _blocks.Add(612, (int)PixelBlock.NormalMagentaBg); //normal_magenta_bg

            //dark
            _blocks.Add(719, (int)PixelBlock.DarkWhiteBg); //dark_white_bg
            _blocks.Add(520, (int)PixelBlock.DarkGrayBg); //dark_gray_bg
            _blocks.Add(652, (int)PixelBlock.DarkBlackBg); //dark_black_bg
            _blocks.Add(523, (int)PixelBlock.DarkRedBg); //dark_red_bg
            _blocks.Add(651, (int)PixelBlock.DarkOrangeBg); //dark_orange_bg
            _blocks.Add(524, (int)PixelBlock.DarkYellowBg); //dark_yellow_bg
            _blocks.Add(525, (int)PixelBlock.DarkGreenBg); //dark_green_bg
            _blocks.Add(526, (int)PixelBlock.DarkCyanBg); //dark_cyan_bg
            _blocks.Add(521, (int)PixelBlock.DarkBlueBg); //dark_blue_bg
            _blocks.Add(522, (int)PixelBlock.DarkMagentaBg); //dark_magenta_bg

            //checker
            _blocks.Add(718, (int)PixelBlock.CheckerWhiteBg); //checker_white_bg
            _blocks.Add(513, (int)PixelBlock.CheckerGrayBg); //checker_gray_bg
            _blocks.Add(650, (int)PixelBlock.CheckerBlackBg); //checker_black_bg
            _blocks.Add(516, (int)PixelBlock.CheckerRedBg); //checker_red_bg
            _blocks.Add(649, (int)PixelBlock.CheckerOrangeBg); //checker_orange_bg
            _blocks.Add(517, (int)PixelBlock.CheckerYellowBg); //checker_yellow_bg
            _blocks.Add(518, (int)PixelBlock.CheckerGreenBg); //checker_green_bg
            _blocks.Add(519, (int)PixelBlock.CheckerCyanBg); //checker_cyan_bg
            _blocks.Add(514, (int)PixelBlock.CheckerBlueBg); //checker_blue_bg
            _blocks.Add(515, (int)PixelBlock.CheckerMagentaBg); //checker_magenta_bg

            //pastel
            _blocks.Add(532, (int)PixelBlock.PastelRedBg); //pastel_red_bg
            _blocks.Add(676, (int)PixelBlock.PastelOrangeBg); //pastel_orange_bg
            _blocks.Add(527, (int)PixelBlock.PastelYellowBg); //pastel_yellow_bg
            _blocks.Add(529, (int)PixelBlock.PastelLimeBg); //pastel_lime_bg
            _blocks.Add(528, (int)PixelBlock.PastelGreenBg); //pastel_green_bg
            _blocks.Add(530, (int)PixelBlock.PastelCyanBg); //pastel_cyan_bg
            _blocks.Add(531, (int)PixelBlock.PastelBlueBg); //pastel_blue_bg
            _blocks.Add(677, (int)PixelBlock.PastelPurpleBg); //pastel_purple_bg

            //candy
            _blocks.Add(539, (int)PixelBlock.CandyPinkBg); //candy_pink_bg
            _blocks.Add(540, (int)PixelBlock.CandyBlueBg); //candy_blue_bg
            #endregion

            #region Decorations

            //meadow
            _blocks.Add(233, (int)PixelBlock.MeadowGrassLeft); //meadow_grass_left
            _blocks.Add(234, (int)PixelBlock.MeadowGrassMiddle); //meadow_grass_middle
            _blocks.Add(235, (int)PixelBlock.MeadowGrassRight); //meadow_grass_right

            _blocks.Add(236, (int)PixelBlock.MeadowBushLeft); //meadow_bush_left
            _blocks.Add(237, (int)PixelBlock.MeadowBushMiddle); //meadow_bush_middle
            _blocks.Add(238, (int)PixelBlock.MeadowBushRight); //meadow_bush_right

            _blocks.Add(239, (int)PixelBlock.MeadowYellowFlower); //meadow_yellow_flower
            _blocks.Add(240, (int)PixelBlock.MeadowSmallBush); //meadow_small_bush


            //Easter
            _blocks.Add(256, (int)PixelBlock.EasterEggBlue); //easter_egg_blue
            _blocks.Add(257, (int)PixelBlock.EasterEggPink); //easter_egg_pink
            _blocks.Add(258, (int)PixelBlock.EasterEggYellow); //easter_egg_yellow
            _blocks.Add(259, (int)PixelBlock.EasterEggRed); //easter_egg_red
            _blocks.Add(260, (int)PixelBlock.EasterEggGreen); //easter_egg_green


            //candy
            _blocks.Add(227, (int)PixelBlock.CandyCreamSmall); //candy_cream_small
            _blocks.Add(431, (int)PixelBlock.CandyCreamLarge); //candy_cream_large
            _blocks.Add(432, (int)PixelBlock.CandyGumdropRed); //candy_gumdrop_red
            _blocks.Add(433, (int)PixelBlock.CandyGumdropGreen); //candy_gumdrop_green
            _blocks.Add(434, (int)PixelBlock.CandyGumdropPink); //candy_gumdrop_pink

            //beach
            _blocks.Add(228, (int)PixelBlock.BeachParasol); //beach_parasol
            _blocks.Add(229, (int)PixelBlock.BeachSandPileRight); //beach_sand_pile_right
            _blocks.Add(230, (int)PixelBlock.BeachSandPileLeft); //beach_sand_pile_left
            _blocks.Add(231, (int)PixelBlock.BeachRock); //beach_rock
            _blocks.Add(232, (int)PixelBlock.BeachRock); //beach_dry_bush
            #endregion

            return _blocks;
        }
    }
}
