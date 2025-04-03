#!/bin/bash
# entrypoint.sh

# Aguarda o início do SQL Server e executa o script setup.sql
# Loop até que o sqlservr esteja disponível

set -e

# Inicia o SQL Server em background
/opt/mssql/bin/sqlservr &

# Aguarda a inicialização do SQL Server
# Ao executar o sqlserver verifique esse caminho e ele era direfente em files
# Ele era assim "/opt/mssql-tools18/bin/sqlcmd"
#Colocar o "-C" Trust server certificate.
until /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "$SA_PASSWORD" -C -d master -Q 'SELECT 1'; do
    echo "SQL Server ainda não está disponível..."
    sleep 5
done

echo "SQL Server iniciado."

# Executa o script SQL
echo "Executando o script 'Inicializacao_DataBase.sql'..."
#Colocar o "-C" Trust server certificate.
/opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "$SA_PASSWORD" -C -d master -i /docker-entrypoint-initdb.d/Inicializacao_DataBase.sql

echo "Script 'Inicializacao_DataBase.sql' executado com sucesso."

# Mantém o processo em foreground para que o Docker possa gerenciá-lo
wait
