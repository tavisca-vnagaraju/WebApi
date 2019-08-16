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
            echo "....Dockering started....."
            bat 'docker build -t webapiimage .'
            echo "image builded"
            bat 'docker images'
            echo 'running docker....'
            bat 'docker run  -p 4567:80  webapiimage'
        }
    }
}