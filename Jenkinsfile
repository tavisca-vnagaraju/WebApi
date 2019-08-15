pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                bat 'dotnet build WebApi.sln -p:configuration=release -v:n'   
            }
        }
        stage('Test'){
          steps  {
                bat 'dotnet test'
          }
       }
       stage('Publish'){
          steps  {
                bat 'dotnet publish'
          }
       }
    }
     post{
                always{
                    archiveArtifacts '**'
                    bat 'dotnet WebApi/bin/Debug/netcoreapp2.2/WebApi.dll'
                }
       }
}