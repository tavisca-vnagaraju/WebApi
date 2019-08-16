pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                powershell(script: 'dotnet build -p:configuration=release -v:n')
            }
        }
        stage('Test'){
          steps  {
                powershell(script: 'dotnet test')
          }
       }
       stage('Publish'){
          steps  {
                powershell(script: 'dotnet publish WebApi -c Release -o artifacts')
          }
       }
       stage('Archive')
        {
            steps
            {
                powershell(script: 'compress-archive WebApi/artifacts publish.zip -Update')
                archiveArtifacts artifacts: 'publish.zip'    
            }
        }
    }
    post{
        success{
            powershell(script: 'docker build -t webapiimage .')
            powershell(script: 'docker run  -p 8979:80  webapiimage .')
        }
    }
}
