pipeline {
    agent any
    parameters{
        string(name:"IMAGE_NAME",defaultValue:"webapi")
        string(name:"SOLUTION_NAME",defaultValue:"WebApi.sln")
        string(name:"DOCKER_USERNAME",defaultValue:"vamsi8979")
        string(name:"DOCKER_PASSWORD",defaultValue:"vamsy123")
        string(name:"DOCKER_REPO_NAME",defaultValue:"webapi")
        string(name:"TAG_NAME",defaultValue:"api")
        
    }
    stages {
        stage('Build') {
            steps {
              powershell(script: 'dotnet build ${env:SOLUTION_NAME} -p:Configuration=release -v:q')   
            }
        }
        stage('Test'){
          steps  {
              powershell(script:'dotnet test')
          }
       }
       stage('Publish'){
          steps  {
              powershell(script:'dotnet publish -c Release -o ../publish')
          }
       }
        stage('Archive'){
            steps {
              archiveArtifacts artifacts: 'publish/*.*',fingerprint:true
            }
        }
        stage('Docker'){
            steps{
              powershell(script:'docker build -t ${env:IMAGE_NAME} .')
              powershell(script:'docker login -u ${env:DOCKER_USERNAME} -p ${env:DOCKER_PASSWORD}')
              powershell(script:'docker tag ${env:IMAGE_NAME}:latest ${env:DOCKER_USERNAME}/${env:DOCKER_REPO_NAME}:${env:TAG_NAME}')
              powershell(script:'docker push ${env:DOCKER_USERNAME}/${env:DOCKER_REPO_NAME}:${env:TAG_NAME}')
            }
        }   
    }
}