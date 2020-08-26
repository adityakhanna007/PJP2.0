Local Repository
Maven local repository is a folder location on your machine. It gets created when you run any maven command for the first time.

Maven local repository keeps your project's all dependencies (library jars, plugin jars etc.). When you run a Maven build, then Maven automatically downloads all the dependency jars into the local repository. It helps to avoid references to dependencies stored on remote machine every time a project is build.

Maven local repository by default get created by Maven in %USER_HOME% directory. To override the default location, mention another path in Maven settings.xml file available at %M2_HOME%\conf directory.

1.Maven local repository is a folder location on your machine.
2.Maven local repository keeps your project's all dependencies (library jars, plugin jars etc).
3.Default location for your local repository - ~/m2./repository.
4.Local Repo uses less storage.
5.It makes checking out project quicker.