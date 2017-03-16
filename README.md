# Log4Net
A POC on Log4Net


**************************
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <configSections>
        <section name="log4net" 
           type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
    </configSections>
    <log4net>
        <appender name="LogFileAppender" type="log4net.Appender.FileAppender">
            <param name="File" value="LogTest2.txt" />
            <param name="AppendToFile" value="true" />
            <layout type="log4net.Layout.PatternLayout">
                <param name="Header" value="[Header]\r\n" />
                <param name="Footer" value="[Footer]\r\n" />
                <param name="ConversionPattern" value="%d [%t] %-5p %c %m%n" />
            </layout>
        </appender>
        
        <appender name="ConsoleAppender" type="log4net.Appender.ConsoleAppender" >
            <layout type="log4net.Layout.PatternLayout">
                <param name="Header" value="[Header]\r\n" />
                <param name="Footer" value="[Footer]\r\n" />
                <param name="ConversionPattern" value="%d [%t] %-5p %c %m%n" />
            </layout>
        </appender>

        <root>
            <level value="INFO" />
            <appender-ref ref="LogFileAppender" />
            <appender-ref ref="ConsoleAppender" />
        </root>
    </log4net>
</configuration>
Within this XML file, you can see that there are two appenders specified, LogFileAppender and ConsoleAppender. We also have a root appender. This specifies what appenders we are using and also what level of output we want to see in our logs – in this case, everything from INFO onwards (i.e., everything except DEBUG). The LogFileAppender specifies which file to use and whether to append onto the end of an existing file or not. Both appenders use a common layout that specifies what information is output to the logs. We can see that the date (%d), time (%t), logging level (%p), the name of the logger (%c) and the message (%m) are output.