@echo off
title Astron-Cluster
cd "../../dependencies/astron/"

astrond --loglevel info config/cluster.yml
pause