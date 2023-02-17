import { ButtonInterface } from "../../interfaces/button"

export const Button = ({ children, onClick, ...rest }: ButtonInterface) => {
    return (
        <button type="submit" onClick={onClick} {...rest}>{children}</button>
    )
}