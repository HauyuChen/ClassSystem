   M S B A M L   `   `   `  ����  ClassSystem    ClassSystem.CStuGradePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  CStuGradePage��5      .��5
      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	datagrid1��5      $
��Left=�6>   $	��Top=�6Y   $	��309��6q   $	��563��6~      AutoGenerateColumns .  $��	12,83,0,0q�6�   ��6&   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 学生学号��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Sno+  5      $ 学生姓名��6%    64   �� *Sname+  5      $ 课程名称��6%    64   �� *Cname+  5      $ 课程成绩��6%    64   �� *Grade+5      �� 5   
   -   5        $��TB_SG��5   N   $��23��6   $��Right=�6   $��
0,48,313,0q�6:   $	��Top=�6[   $	��104��6s   �� 5   
   -   5        $��label1��5   b   $-��'请输入你要查询学号或姓名：��6   $��28��6(   $
��Left=�64   $��	12,46,0,0q�6O   $	��Top=�6p   �� 5   
   -   5        $��BTN_SG_Search��5   Z   $��查询��6   $��23��6   $��Right=�6*   $��
0,48,221,0q�6F   $	��Top=�6o   $��75��6�   6�   �� 5   
   -   5        $��label2��5   [   $��学生成绩查询��6   $��34��6!   $
��Left=�6-   $��	225,4,0,0q�6H   $	��Top=�6i   $��20(�6�   $
��Bold"�6�   5      5      