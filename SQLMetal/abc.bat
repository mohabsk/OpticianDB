@echo off
C1\SQLCreate.exe ../Resources/blankdb.sql
C2\DBMetal.exe /namespace:OpticianDB /provider:SQLite "/conn:Data Source=blankdb.db3" /database=OpticianDB /code=DBAdaptor.cs
del blankdb.db3