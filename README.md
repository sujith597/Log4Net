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

some benifits of nLog over Log4Net
1.Setting/starting up with NLog is dead easy. You go through the Getting started tutorial on their website and you are done. You get a fair idea, how thing might be with nlog. Config file is so intuitive that anyone can understand the config. For example: if you want to set the internal logging on, you set the flag in Nlog config file's header node, which is where you would expect it to be. In log4net, you set different flags in web.config's appSettings section.
2.In log4net, internal logging doesnt output timestamp which is annoying. In Nlog, you get a nice log with timestamps. I found it very useful in my evaluations.
3.Filters in log4net - You better check my this question - log4net filter - how to write AND filter to ignore log messages and if you find an answer/solution for this, please let me know. I understand, there is a workaround for this question, as you can write your own custom filter. But something which is not easily available in log4net.
4.Performance - I logged around 3000 log messages to database using a stored procedure. I used simple for loop (int i=0; i<3000; i++... to log the same message 3000 times. For the writes: log4net AdoAppender took almost double the time than NLog.
5.Log4net doesnt support asynchronous appender.