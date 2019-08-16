pipeline {
    agent any
    parameters{
      string(name:'SOLUTION_PATH')
    }
    stages {
        stage('Build') {
            steps {
                powershell(script: "echo 'Given Solution Path is :$env:SOLUTION_PATH'")
                powershell(script: "'dotnet build $env:SOLUTION_PATH -p:configuration=release -v:n'")
            }
        }
        stage('Test'){
          steps  {
                powershell(script: "'dotnet test'")
          }
       }
       stage('Publish'){
          steps  {
                powershell(script: "'dotnet publish'")
          }
       }
    }
    post{
        success{
            powershell(script: "'echo....archiving artifacts.....'")
            powershell(script: "'echo....archiving artifacts.....'")
            powershell(script: "'docker build -t webapiimage .'")
            powershell(script: "'docker run  -p 8979:80  webapiimage .'")
        }
    }
}
