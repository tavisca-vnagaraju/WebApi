pipeline {
    agent any
    parameters{
      string ('name':'SOLUTION_PATH')
    }
    stages {
        stage('Build') {
            steps {
                echo "========================one =============================================="
                echo "params.SOLUTION_PATH %params.SOLUTION_PATH}%"
                echo "=========================two============================================="
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