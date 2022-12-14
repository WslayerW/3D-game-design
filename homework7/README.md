### 实验题目：智能巡逻兵

20337245魏一鸣

### 实验要求：

![image-20221205044216638](C:\Users\Lenovo\AppData\Roaming\Typora\typora-user-images\image-20221205044216638.png)

### 设计思路

* 订阅发布的设计模式

  * 持续的对每一个游戏对象进行检测是十分消耗游戏资源的，对于玩MineCraft的我来说实际上比较能够体验这一点的重要性，在MC的红石系统中就采用了这样一种订阅发布的模式，目的是减少红石线路带来的资源损耗，降低游戏卡顿，如果在游戏中使用过多的红石粉就会导致游戏帧数的较大幅度的下降

  * 在菜鸟教程的C#教程中提到，C#专门的为订阅发布模式提供了一种实现方法，即通过C#事件系统调用委托

    ![image-20221205045150787](C:\Users\Lenovo\AppData\Roaming\Typora\typora-user-images\image-20221205045150787.png)

  * 在巡逻兵的实现过程中容易想到的几处需要用到订阅发布模式的点：

    （1）奖励事件

    ​			游戏中的奖励资源是提前设置的，但是在玩家获得前不应当投入过多资源记录（游戏中的获得水晶）

    （2）惩罚事件

    ​			最容易想到的是掉血事件，玩家的血条不是无时无刻都在掉的（除非有debuff，但很显然现在没有），所以不需要一直分配资源维护，在该游戏中由于一击必杀所以与结束事件等效

    （3）结束事件

    ​			游戏的结束应当是一种触发造成的状态，由某种条件打成

* NPC及主角
  * 使用Unity Store提供的资源直接使用动画，省去了对于建模的设计等步骤（同时超出能力范围）
  * 视角采用第三人称的俯视视角（第一人称没有找到合适的资源，向下斜视的第三人称，由于场景预制的问题，鼠标位置容易受到区块边界的影响，所以放弃使用）