## Building this software

1. sudo apt install mono-complete (See note below)/ sudo dnf install mono-devel
2. git clone https://github.com/ASDFDev/PAS-Backend-ASPNET.git
3. Download [NuGet](https://www.nuget.org/)
4. cd PAS-Backend-ASPNET
5. mono /path/to/nuget/exe restore
6. xbuild Setsuna.sln
 
The software would be built and you can start running the software! Go to [SetsunaOnApache.md](SetsunOnApache.md) for more info on how to run this software on Apache. You should only use XSP for debugging purpose. See [SetsunaOnXsp.md](SetsunaOnXsp.md) for more info on running this software on XSP.

`Note: For Debian derivatives, it is possible to run this software without pulling all of mono packages and dependencies.`

