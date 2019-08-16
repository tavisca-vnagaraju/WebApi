pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                bat 'dotnet build -p:configuration=release -v:n'
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
            echo "....archiving artifacts....."
            archiveArtifacts '**'
            bat 'docker run  -p 8979:80  webapiimage'
        }
    }
}