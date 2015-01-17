;WindowsForms10.SysTreeView32.app.0.34f5582_r45_ad11

SetTitleMatchMode, 2
#IfWinActive Microsoft SQL Server Management Studio
#`:: 
{
    InputBox, UserInput, Filter, Please type in a filter, , 200, 100
    
    if ErrorLevel
        exit
    else
    {
        send {AppsKey}
        sleep 100
        
        if (UserInput)
        {
            send ts
            sleep 100
            send {Tab 2}
            send %UserInput%
            sleep 100
            send {Enter 6}
        }
        else
        {
            send tm
        }
        
    }
}
