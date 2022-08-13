FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["CourseApi/CourseApi.csproj", "CourseApi/"]
RUN dotnet restore "CourseApi/CourseApi.csproj"
COPY . .
WORKDIR "/src/CourseApi"
RUN dotnet build "CourseApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CourseApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CourseApi.dll"]
