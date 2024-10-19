# 專案名稱
個人化桌面工具組

## 專案描述
這是一個可以個人化並放在桌面的Windows Form
集結了我們日常所需的工具

## 開發環境

- 開發工具: Visual Studio 2022
- 開發語言: C#

## 專案結構

描述專案的基本結構，包括主要程式檔案、資源檔、設定檔等。

- final_project.sln
- packages
- final_project_test/
  - Form1.cs
  - Form2.cs
  - ...
  - ClockForm.cs
  - CalendarForm.cs
  - ConvertFileForm.cs
  - Program.cs
  - SetAccountForm.cs
  - ToDoListForm.cs
  - Weather.cs

## 主要功能
1. 網站捷徑
   -主畫面最左側是可以設定一排網站捷徑按鈕，按下去之後可以開啟chrome去到指定網站
   -可以點選左下角的兩個按鈕來新增或是刪除按鈕 

2. 專注模式
   -可以在主畫面查看目前時間
   -點擊後可以進入專注模式的畫面來 設定鬧鐘 / 倒數計時 / 碼表計時 這三種功能

3. 行事曆
   -主畫面右側有當天的行事曆可以查看(可滾動查看)
   -點選主畫面的(Add New Schedule)按鈕可以進入新增行事曆的畫面 

4.代辦事項
   -主畫面右側有當天的代辦事項可以查看(可滾動查看)
   -點選主畫面的(Add New To-Do List)按鈕可以進入新增代辦事項的畫面 

5.天氣預報
   -在主畫面的中間區塊是天氣預報的區域
   -可以選取縣市跟區域，選好之後就會在旁邊顯示當地的天氣詳情

6.控制播放線上音樂
   -主畫面中間下面的區域是控制播放線上音樂的地方
   -在textbox(顯示please enter song name)輸入音樂名稱後按下Search按鈕，就會自動在youtube music上搜尋並播放
   -可以點擊 開始&暫停 / 下一首 / 上一首 這三個按鈕來控制播放音樂

7.檔案格式轉換器
   -在主畫面按下檔案轉換的按鈕可以進入檔案格式轉換器的畫面
   -可以點擊select或是直接拖曳檔案來選取要轉換的檔案本人
   -選取完檔案後會自動偵測檔案類型，之後就可以選取要轉換的檔案格式

## 如何使用
1. 開啟專案後按下啟動
2. 找到並執行 final_project_v5/final_project_test/Debug/final_project_test.exe