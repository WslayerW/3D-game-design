<center><font size ="6">Slay The Spire游戏设计分析<font></center>

[toc]

```
Slay the Spire是一个由Mega Crit Games开发和更新的游戏。杀戮尖塔在2017年11月15日在Steam平台上开始了抢先体验。制作组尽力结合rougelike和卡牌游戏这两种风格，带给玩家最好的DBG游戏！组建一个独一无二的套牌，发现最强大的遗物，击败最可怕的敌人，在尖塔上肆意杀戮！                                                                                                 																						————杀戮尖塔中文wiki
```

##一、简介

杀戮尖塔（"slay the spire"中文翻译，由于其游戏的进程酷似爬塔，所以在广泛的玩家群体中称为"爬塔"，在下文中我们以"爬塔"代称杀戮尖塔）是一款优秀的roguelike[1]单机卡牌游戏，玩家在游戏中有两个初始可选角色以及两个可解锁角色，在每一局游戏中，玩家从0开始，根据每位角色的初始卡组，经过一系列的战斗以及尖塔事件，打败最终boss，取得游戏的胜利。

虽然每一局总体的流程相同，但是由于每一局所有事件以及所有对战的全随机性，每一局游戏带给玩家的体验都是独一无二的。玩家可以在一次次的爬塔中一次次精进自己的牌技，逐渐挑战更高的难度，充分发挥各角色独有的特色，吸取每一次破灭（失败）带来的经验，享受每一次胜利带来的成就感。

##二、玩家

####1.人数

爬塔作为一个单机游戏，默认的游戏人数为1人，但是作为一款风靡一时的热销游戏，steam版的杀戮尖塔可以在启动时选择play with the mods选项，加载多人联机mod，此时可支持最多4人的同时玩法。

#### 2.交互模式

经典单人模式：单独玩家和游戏对战

bingo模式（多人）：玩家与玩家对抗（多边）

对抗模式：玩家与玩家对抗

合作模式：玩家之间互相合作

##三、规则和目标（经典模式）

仅仅说明经典模式，原因是mod均为玩家社区开发，官方设计中不曾考虑多人联机的元素

####1.普通模式

游戏中的卡牌是战斗的主要方式。有具有每个角色自身特色的专属卡牌，也有各职业通用的中立卡牌。大部分卡牌在一场战斗中是可重复使用的。卡牌存在行动花费点数，打出后将减少玩家相应的行动点数。游戏卡牌根据类型分为攻击牌、技能牌、能力牌。

每回合开始时，玩家可从抽牌堆抽5张牌，并获得3点行动点。打出手牌需要花费能量点。在玩家回合中，可以在敌人上方看见他们的意图；玩家的回合结束后，手牌会移到玩家的弃牌堆。

玩家最多可持有10张牌，多余的牌将直接被移到玩家的弃牌堆。当玩家抽牌堆没牌时，弃牌堆将洗牌加入至抽牌堆。

杀死对手以赢得战斗，击杀最终boss取得胜利

#### 2.自定义模式

在普通模式的基础上：

- 自定义模式允许玩家自行制定需要的特效和各种选项，充分体验游戏乐趣。
  - 关于自定模式的特效，请参考自定义模式页面。

- 该模式中可以选择无尽模式，无尽模式可以进行无尽的轮回，但每一轮游戏阶段结束后会获得荒疫。
  - 荒疫箱可以增大无尽模式的挑战。

- 自定模式的[终幕]选项，于对应角色在标准模式下打败一次心脏后解锁。

- 进行一局每日挑战模式后解锁该模式。

####3.每日挑战

- 每日挑战模式中，每天均会产生不同的特效，玩家们在这些特效下进行游戏挑战，并将最终的分数上传至排行榜进行竞技。
  - 每日挑战每天只能上传一次分数。
  - 你可以查阅过去几天每日挑战的排行榜。

- 进行一场标准模式的对局后解锁。

## 四、资源

####1.金钱

尖塔中的货币，可以在商店中用来购买卡牌、遗物、药水或删牌，可以通过打怪获得，部分事件也可以获得金币

#### 2.药水

药水是只能在战斗中使用的一次性消耗品。通过商店购买、战斗奖励掉落、事件可获得。每局游戏初始将有3个药水栏位，超过上限则只能丢弃栏位的药水或跳过奖励。

#### 3.遗物

遗物是角色在一局游戏中获得的永久物品，为角色提供各种能力的增持，并且会一直保留到一局游戏的结束。除角色独有遗物，也存在通用遗物。在每局游戏中，遗物一旦获得便无法自主移除，但可通过遭遇的事件移除。已获得的遗物不会再次出现。遗物根据获取方式的不同，存在相应稀有度。

#### 4.卡牌

卡牌是杀戮尖塔中最基础的资源，玩家在大多数的战斗和事件中都有机会获得卡牌，玩家通过卡组的构筑最终在其它资源的辅助下最终完成通关的游戏目的

##五、冲突

杀戮尖塔作为一款优秀的roguelike游戏，其关键的冲突在于牌组各方面的强度与各个怪物不同特性之间的冲突。尤其在高进阶[3]的情况下，一套优秀的卡组不能够只在某个方面强度高，而是要考虑每一层的各个怪物的要求，例如第一层强调攻杀，第二层考验防守，第三层考验综合强度。如何综合考虑卡组的牌位资源，抽牌和卸牌强度等，是爬塔主要的冲突和乐趣所在

##六、注释

####1.roguelike

Roguelike是一类游戏的统称。 [1] 指沿袭了二十世纪八十年代由Michael Toy和Glenn Wichman两位软件工程师共同在UNIX系统上开发，在大型机上运行的游戏《Rogue》 [10] 玩法的游戏作品。其类型始祖游戏《rogue》在2009年被游戏权威杂志“PC WORLD”评为“史上最伟大的十个游戏之一”。

Roguelike类型游戏在出现频率较高的特点包括：

1、生成随机性。每一次新开局游戏都会随机生成游戏场景，敌人，宝物等不同事物。而玩家的每一次冒险历程也都将是独一无二，不可复制的。

2、进程单向性。当你在玩一款Roguelike游戏时，存档功能的唯一作用就是记录你当前的游戏进度，每当存档被读取时，对应的进度就会被清空，直到你进行下一次存档。

3、不可挽回性。在大多数Roguelike游戏中，每一个角色只有一次生命，一个角色的死亡意味着玩家将永远失去该角色。

4、游戏非线性。严谨而不失灵活性的游戏规则，使Roguelike具备了极高的自由度，在游戏中，玩家可以发挥想象力，利用各种手段去达成任何他们想做的事情，或合乎常理，或匪夷所思，目的只在于解决他们在游戏中遇到的问题。

5、系统复杂性。Rogue本身的复杂程度就远远超过同时期的任何一款作品。而Roguelike类游戏可能会在一款游戏中包括多到无法估量的元素，例如地质、气候和生物分布，以及精细到皮肤、肌肉、血液、骨骼和脂肪的战斗系统，甚至战损痊愈后会留下伤疤以及后遗症。

#### 2.卡牌类型描述

| 攻击牌 | 直接对敌人造成伤害并可能附带一些其它效果的卡牌         |
| ------ | ------------------------------------------------------ |
| 技能牌 | 没有明确的进攻或者防守的倾向，具有更多独特的效果的卡牌 |
| 能力牌 | 为整场战斗提供持续性效果，每场战斗只能使用一次的卡牌   |

#### 3.进阶

在通关一次后可以逐渐解锁更高模式的进阶难度，具体的进阶难度描述如下：

1、精英敌人出现更加频繁。

2、普通敌人造成更多伤害。

3、精英敌人造成更多伤害。

4、BOSS敌人造成更多伤害。

5、BOSS战后生命恢复减少。

6、游戏开始时受到伤害。

7、普通敌人拥有更多生命。

8、精英敌人拥有更多生命。

9、BOSS敌人拥有更多生命。

10、初始拥有诅咒。

11、药水栏位变少。

12、升级过的牌出现频率下降。

13、BOSS变穷。

14、最大生命值下降。

15、部分事件变得更加不利。

16、商店要价更高。

17、普通敌人的行动和能力变强。

18、精英敌人的行动和能力变强。

19、BOSS敌人的行动和能力变强。

20、（最大难度）双重BOSS。
