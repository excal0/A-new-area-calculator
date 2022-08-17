现在让我们开始体验Markdown语言的魅力。

> 举一纲而万目张, 解一卷而众篇明
> ——汉·郑玄《诗谱序》

一篇文档的内容组织结构可分为：
* 标题
* 目录
* 分章节的正文
* 参考文献

一篇文档的内容表达形式可分为：
* 文字与段落
* 图形
* 表格
* 公式

Table of contents
[toc]

# 1.标题 Markdown

---
* 第一种写法

在一行文本的开头输入若干个"#"，并用一个空格与文本分隔，该行文本即可识别为相应等级的标题。
最小标题位6级。

``` markdown
# 一级标题
## 二级标题
### 三级标题
#### 四级标题
##### 五级标题
###### 六级标题
```
实际效果：
# 一级标题
## 二级标题
### 三级标题
#### 四级标题
##### 五级标题
###### 六级标题

---

* 第二种写法

一级标题的另一种写法，在一行文字下方连续输入3个以上的等号"="
二级标题的另一种写法，在一行文字下方连续输入3个以上的减号"-"

``` markdown
这是一级标题
===
```

``` markdown
这是二级标题
---
```

实际效果：

这是一级标题
===

这是二级标题
---

---

* 第3种写法

与第1种写法类似

# 一级标题 #
## 二级标题 ##
### 三级标题 ###

# 2. 文本样式

## *斜体* _斜体_
在正文中想要倾斜的效果，可以在文字的前后分别输入1个星号"*",或短下划线"_"

## **粗体** __粗体__
在正文中想要加粗的效果，可以在文字的前后分别输入2个星号"*",或短下划线"_"

## **_斜体+粗体_** __*斜体+粗体*__
__*斜体+粗体*__
*__斜体+粗体__*

## <label style="color:red">颜色</label>

这是<label style="color:red">红色</label>字体
这是<label style="color:blue">蓝色</label>字体
这是<label style="color:green">绿色</label>字体

这是<label style="color:#ff0000">红色</label>字体
这是<label style="color:#00ff00">绿色</label>字体
这是<label style="color:#0000ff">蓝色</label>字体

这是<label style="color:#f00">红色</label>字体

## ~~删除~~
在正文中想要~~删除~~的文字前后分别输入两个波浪号"~~"

## 下划线
在正文中想要<u>下划线</u>的文字前后分别输入"`<u>`"和"`</u>`"

# 3.段落
Markdown语言中的换行符

这是第一行



这是第二行  
这是第三行<br>这是第四行


    如果要加入内容框，想要特别强调某个段落。可以在该段的开头连续输入4个空格。
    此处为连续强调的段落。如果想跳出强调段落，只需插入一行空行。

此处跳出内容框

# 4.引用

当在一段文字前输入大于号">"，并用一个空格与正文分隔，这段话就会以引用的方式呈现，例如：

> 这是一句引用。

引用+强调

>     这是一句被强调的引用。

引用嵌套，只需要不断增加正文前的大于号">"。
> 这是第一层的引用。
>> 这是第二层的引用。
>>> 这是第三层的引用

# 5.代码

在文档中的某一行插入一句较短的代码片段，可以在代码的前后输入一个反撇号"`"（键盘ESC键下方波浪线“~”所在键）,例如：

我们今天学习了Markdown语言，并写出了第一句代码`alert("Hello world");`

如果想输入成段代码，可以将成段的代码以三个连续的反撇号"`"包围。如果需要根据语言高亮代码，直接在反撇号后加入语言名称

``` 
# 未高亮的代码片段
def Function():
    a=0
    b=1
    print((a+b))
    pass
```

``` python
# 高亮后的代码片段
def Function():
    a=0
    b=1
    print((a+b))
    pass
```

``` javascript
alert("Hello World")
```

``` csharp
namespace demo{
    public class MyClass{
        public MyClass(){

        }

        private int _value;
    }
}

```

# 6.列表

在Markdown中的列表有两种：无序列表和有序列表。

无序列表：
在文字开头添加一个星号"*"，或者是加号"+"，减号"-"，并用空格与正文分隔，即可创建无序列表。需要注意的是：一个文档中，最好统一无序列表的定义风格。

* 这是一个无序列表的第一项
* 这是第二项
* 这是最后一项

+ 这是一个无序列表的第一项
+ 这是第二项
+ 这是最后一项

- 这是一个无序列表的第一项
- 这是第二项
- 这是最后一项

有序列表：
在文字的开头，添加一个阿拉伯数字和一个点"."，并用空格与正文分隔，即可创建有序列表。

1. 这是一个有序列表的第一项
2. 这是第二项
100. 注意：不管输入的是什么数字，渲染后的有序列表都会按顺序进行递增！！！

# 7.分割线

在Markdown中，在一个空行后另起一行的开头输入3个以上的星号"*"，或者减号"-"，即可插入一条分割线。

---

***

* * *
- - -

# 8.链接

在Markdown中插入链接，需要采用方括号圆括号组合的形式，方括号中设置链接的文本，圆括号中设置包含链接的地址。例如：

这是一个[Github](https://www.github.com/)的链接

链接可以加粗或者斜体
**这是一个[Github](https://www.github.com/)的链接**

*这是一个[Github](https://www.github.com/)的链接*

Email也是一种特殊的链接
Email:<sec2022@hust.edu.cn>

# 9.图片

在Markdown文档中插入图片与插入链接的方式非常相似。

!代表的图片
[]里面是图片显示不出的时候显示文字
()里面是图片地址

例如：

``` markdown
![恭喜完成](finish.png "恭喜你已经掌握Markdown语言的基本语法")
```

![恭喜完成](finish.png "恭喜你已经掌握Markdown语言的基本语法")


---

# 高级用法

# 10.脚注

这是脚注[^1]

[^1]:注释脚注说明，将会在文章的末尾显示。

# 11.表格

| Title1  | Title2  | Title3  |
| ------- | ------- | ------- |
| Cell_11 | Cell_12 | Cell_13 |
| Cell_21 | Cell_22 | Cell_23 |
| Cell_31 | Cell_32 | Cell_33 |

| Title1           |    Title2    |           Title3 |
| :--------------- | :----------: | ---------------: |
| <-左对齐<-左对齐  | ->居中对齐<-  | 右对齐->右对齐->  |
| Cell_21          |   Cell_22    |          Cell_23 |
| Cell_31          |   Cell_32    |          Cell_33 |

<table>
    <thead>
        <td align="left">Title1</td>
        <td align="center">Title2</td>
        <td align="right">Title2</td>
    </thead>
    <tbody>
        <tr>
            <td>Cell_21</td>
            <td>Cell_22</td>
            <td>Cell_23</td>
        <tr>
        <tr>
            <td>Cell_31</td>
            <td>Cell_32</td>
            <td>Cell_33</td>
        <tr>
    </tbody>
</table>

# 12.图片位置的设置

![左对齐](calculator-demo/logo.jpg "华中科技大学")

<img src="logo.jpg" width="500px" style="margin-left:100px">

<p align="left">这是左对齐的段落</p>

<p align="right">这是右对齐的段落</p>

<center>这是居中对齐的段落</center>

<center><img src="logo.jpg"></center>

<p align="right"><img src="logo.jpg"></p>

# 13.计划任务

- [x] 待办任务1
- [x] 2021年8月16日待办任务
- [ ] 任务3

# 14.LaTex数学公式

使用LaTex数学公式
1. 行内公式

使用两个"$"符号引用公式，例如:

此处为行内$公式$

2. 行间公式

使用两对"$$"符号引用公式，例如：

$$公式$$

正态分布 $\N(\mu,\sigma^2)$的概率密度函数：

$$ f(x) = \frac{1}{\sqrt{2\pi}\sigma}{e^{-\frac{(x-\mu)^2}{2\sigma^2}}} $$

积分：

$$ y = \int_{-\infty}^{\infty}{f(x)}dx $$

矩阵

$$ \left|
\begin{array}{lcr}
a & b & c\\
d & e & f\\
\end{array}
\right|
$$

# 15.高级技巧
## 支持的 HTML 元素

不在 Markdown 涵盖范围之内的标签，都可以直接在文档里面用 HTML 撰写。
目前支持的 HTML 元素有：`<kbd> <b> <i> <em> <sup> <sub> <br> <u>`等 ，如：

`<kbd>` keyboard: <kbd>Ctrl</kbd>+<kbd>Alt</kbd>+<kbd>A</kbd>
`<b>` bold: <b>加粗</b>
`<i>` italic: <i>斜体</i>
`<em>` emphasize: <em>强调</em>
`<sup>` superscript: 这个是<sup>上标</sup>
`<sub>` subscript: 这个是<sub>下标</sub>
`<br>` break: 这个是<br>换行
`<u>` underline: <u>下划线</u>
## 转义

Markdown 使用了很多特殊符号来表示特定的意义，如果需要显示特定的符号则需要使用转义字符，Markdown 使用反斜杠转义特殊字符：

\*\*加粗转义\*\*
\*\*斜体转义\*\*
\#一级标题转义\#

Markdown 支持以下这些符号前面加上反斜杠来帮助插入普通的符号：
```
\   反斜线
`   反引号
*   星号
_   下划线
{}  花括号
[]  方括号
()  小括号
#   井字号
+   加号
-   减号
.   英文句点
!   感叹号
```

# 16.emoji

恭喜你顺利完成了Markdown基本语法的学习 :smile:
祝贺你！:thumbsup: :clap: :joy:

:smile: :laughing: :blush: :smiley: :relaxed: :smirk: :heart_eyes: :kissing_heart: :kissing_closed_eyes: :flushed: :relieved: :satisfied: :grin: :wink: :stuck_out_tongue_winking_eye: :stuck_out_tongue_closed_eyes: :grinning: :kissing: :kissing_smiling_eyes: :stuck_out_tongue: :sleeping: :worried: :frowning: :anguished: :open_mouth: :grimacing: :confused: :hushed: :expressionless: :unamused: :sweat_smile: :sweat: :disappointed_relieved: :weary: :pensive: :disappointed: :confounded: :fearful: :cold_sweat: :persevere: :cry: :sob: :joy: :astonished: :scream: :tired_face: :angry: :rage: :triumph: :sleepy: :yum: :mask: :sunglasses: :dizzy_face: :imp: :smiling_imp: :neutral_face: :no_mouth: :innocent: :alien:

——华中科技大学电气学院-2022软件工程训练营





























