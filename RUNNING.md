## Running this software

Currently I am using xsp4 to run this software, using Apache _IS_ possible

# Debian / Ubuntu derivatives

1. sudo apt install mono-complete xsp4 (see note below)
2. git clone https://github.com/ASDFDev/PAS-Backend-ASPNET.git
3. cd PAS-Backend-ASPNET
4. sudo mkdir /etc/mono/registry && sudo chmod uog+rw /etc/mono/registry
5. xsp4
6. open your browser and go to http://localhost:9000

`NOTE:It is possible to run this software without pulling all of mono packages and dependencies.`

# Fedora derivatives

1. sudo dnf install mono-devel xsp
2. git clone https://github.com/ASDFDev/PAS-Backend-ASPNET.git
3. cd PAS-Backend-ASPNET                                    
4. sudo mkdir /etc/mono/registry && sudo chmod uog+rw /etc/mono/registry
5. xsp4
6. open your browser and go to http://localhost:9000

