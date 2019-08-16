pipeline {
    agent any
    parameters{
      string ('name':'SOLUTION_PATH')
    }
    stages {
        stage('Build') {
            steps {
                bat 'dotnet build %params.SOLUTION_PATH% -p:configuration=release -v:n'
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
        success{
            archiveArtifacts '**'
        }
    }
}