pipeline {
    agent any
    parameters{
      string(name:'SOLUTION_PATH')
    }
    stages {
        stage('Build') {
            steps {
                bat "echo 'Given Solution Path is :%SOLUTION_PATH%'"
                bat 'dotnet build %SOLUTION_PATH% -p:configuration=release -v:n'
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
            bat "echo....archiving artifacts....."
            archiveArtifacts '**'
            bat 'docker build -t webapiimage .'
            bat 'docker run  -p 8979:80  webapiimage .'
        }
    }
}
