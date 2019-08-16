pipeline {
    agent any
    parameters{
      string ('name':'SOLUTION_PATH')
    }
    stages {
        stage('Build') {
            steps {
                echo "======================================================================"
                echo "parameters.SOLUTION_PATH ${parameters.SOLUTION_PATH}"
                echo "params.SOLUTION_PATH ${params.SOLUTION_PATH}"
                echo "name.SOLUTION_PATH ${name.SOLUTION_PATH}"
                echo "======================================================================"
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