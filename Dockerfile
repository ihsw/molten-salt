FROM microsoft/dotnet

COPY ./app /srv/app
WORKDIR /srv/app/src
RUN dotnet build

CMD ["dotnet", "run"]