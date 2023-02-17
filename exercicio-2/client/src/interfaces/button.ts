import React, { ReactNode } from "react"

export interface ButtonInterface {
    children: ReactNode
    onClick?: () => void
    [rest:string]: any
  }