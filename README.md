# MetaGov
Freedom For All

Instructions (linux)

wget -q packages-microsoft-prod.deb https://packages.microsoft.com/config/ubuntu/16.04/packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb

sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install dotnet-sdk-2.1.200

make sure you have npm installed

navigate to MetaGovAPI directory
dotnet run
