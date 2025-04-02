FROM mcr.microsoft.com/mssql/server:2022-latest
USER root
EXPOSE 1433

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=#sa123456
ENV MSSQL_PID=Express

COPY SQL/Inicializacao_DataBase.sql /docker-entrypoint-initdb.d/

COPY --chmod=755 entrypoint.sh /usr/src/app/entrypoint.sh
ENTRYPOINT ["bash", "/usr/src/app/entrypoint.sh"]

CMD ["/opt/mssql/bin/sqlservr"]