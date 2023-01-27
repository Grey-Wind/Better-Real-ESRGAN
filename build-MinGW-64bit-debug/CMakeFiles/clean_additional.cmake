# Additional clean files
cmake_minimum_required(VERSION 3.16)

if("${CONFIG}" STREQUAL "" OR "${CONFIG}" STREQUAL "Debug")
  file(REMOVE_RECURSE
  "Better_Real-ESRGAN_autogen"
  "CMakeFiles\\Better_Real-ESRGAN_autogen.dir\\AutogenUsed.txt"
  "CMakeFiles\\Better_Real-ESRGAN_autogen.dir\\ParseCache.txt"
  )
endif()
