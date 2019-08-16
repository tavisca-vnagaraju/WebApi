pipeline {
    agent any
    parameters{
      string(name:'PATH')
    }
    stages {
        stage('Build') {
            steps {
                powershell 'dotnet build WebApi.sln -p:configuration=release -v:n'
            }
        }
        stage('Test'){
          steps  {
                powershell 'dotnet test'
          }
       }
       stage('Publish'){
          steps  {
                powershell 'dotnet publish $env:PATH -c Release -o artifacts'
          }
       }
       stage('Archive')
        {
            steps
            {
              powershell 'docker build -t webapiimage .'
            }
        }
    }
    post{
        success{
            powershell 'docker run  -p 8979:80  webapiimage .'
        }
    }
}