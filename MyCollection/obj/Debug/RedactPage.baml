   M S B A M L   `   `   `  ����G  CMyCollection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MyCollectionMyCollection  5          MyCollection.RedactPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MyCollection     5        N� Title$  
RedactPage��5	      .��5      � .+�5   
   �� $��Images\back.jpeg��6   $
��Fill=�6*    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5         Radius$ 20Q�6   5      �� 5   
   -   5        $��imageContainer��5      $��
310,10,0,0q�6&   $	��132��6:   $	��Top=�6G   $
��Left=�6_   $	��178��6z   $��Images/noimage.png��6�   $
��Fill=�6�   �� 5   
   -   5        $��Загрузить��5      $
��Left=�6%   $��351,158,0,0q�6@   $	��Top=�6U   $	��102��6m   6y   �� 5   
   $
��Left=�6   $��
24,221,0,0q�6/   $
��Wrap=�6C   $��Тип элемента: ��6W   $	��Top=�6m   �� 5   
   -   5        $��comboBoxType��5      $
��Left=�6'   $��133,221,0,0q�6B   $	��Top=�6W   $	��120��6o   6{   �� 5   
   -   5        $��OtherTextBlock��5      $
��Left=�6*   $��441,221,0,0q�6E   $
��Wrap=�6Z   $��Другое:��6n   $	��Top=�6}   �� 5   
   -   5        $��OtherTextBox��5      $
��Left=�6&   $��23��6A   $��550,221,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   �� 5   
   $
��Left=�6   $��
24,284,0,0q�6/   $
��Wrap=�6C   $��Просмотрено:��6W   $	��Top=�6k   �� 5   
   -   5        $��comboBoxIsWatched��5      $
��Left=�6,   $��133,284,0,0q�6G   $	��Top=�6\   $	��120��6t   6�   �� 5   
   $
��Left=�6   $��
24,254,0,0q�6/   $
��Wrap=�6C   $��Ссылка:��6W   $	��Top=�6f   �� 5   
   -   5        $��LinkText��5      $
��Left=�6"   $��23��6=   $��133,254,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��307��6�   �� 5   
   -   5        $��RateText��5      $
��Left=�6$   $��441,284,0,0q�6?   $
��Wrap=�6T   $��Оценка:��6h   $	��Top=�6w   �� 5   
   -	   5        $��RateComboBox��5      $
��Left=�6'   $��550,284,0,0q�6B   $	��Top=�6W   $	��120��6o   �� 5   
   -
   5        $��Сохранить��5      $
��Left=�6%   $��334,361,0,0q�6@   $	��Top=�6U   $	��106��6m   6y   �� 5   
   $
��Left=�6   $��
24,330,0,0q�6/   $
��Wrap=�6C   $��Название:��6W   $	��Top=�6h    J� RenderTransformOrigin$ 
0.53,0.482&�6�   �� 5   
   -   5        $��nameText��5      $
��Left=�6"   $��29��6=   $��133,330,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��307��6�   �� 5    
   -   5        $��
Назад��5       $
��Left=�6!   $��	24,34,0,0q�6<   $	��Top=�6O   $��75��6g   6r   5!      5"      