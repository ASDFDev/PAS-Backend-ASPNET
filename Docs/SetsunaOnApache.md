## Running this software on Apache

Ensure you have build the software first! See [BUILDING.md](BUILDING.md) for more details.

1. sudo apt install apache2 mono-apache-server4 libapache2-mod-mono libmono-i18n4.0-cil
2. sudo systemctl start apache2 && sudo a2enmod mod_mono_auto.conf
3. copy mod_mono_auto.conf from Extra/ directory to /etc/apache2/mods-available/
4. sudo systemctl reload apache2
5. cd Setsuna
6. sudo cp Global.* /var/www/html
7. sudo cp *.config /var/www/html
8. sudo cp -r Views/ /var/www/html
9. sudo cp -r bin/ /var/www/html

