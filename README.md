## Running Demos

- Run `docker compose up`
- Open browser to `http://localhost:8081`
- Login
  - Username: test@featbit.com
  - Password: 123456
- Create Feature Flag `test`
- Toggle On

### React

- Run `docker compose up` from the root directory.
- Create `test` flag Key must be `test` OR flag name can be changed by replace `test` on [App.jsx L9](https://github.com/jeffrey-vang/FeatBit-JV/blob/e49d9d3bb583ebb3dafe03a8c8d95b0a733aff39/demos/react/src/App.jsx#L9) & [App.jsx L17](https://github.com/jeffrey-vang/FeatBit-JV/blob/e49d9d3bb583ebb3dafe03a8c8d95b0a733aff39/demos/react/src/App.jsx#L17)
- Paste Client Key to [main.jsx L9](https://github.com/jeffrey-vang/FeatBit-JV/blob/e49d9d3bb583ebb3dafe03a8c8d95b0a733aff39/demos/react/src/main.jsx#L9)
- Run `npm run dev`
- Toggling flag or updating targeting rules should rerender trigger live updates in UI.

Off
- <img width="562" height="460" alt="image" src="https://github.com/user-attachments/assets/b6de6b1e-bdd9-4245-99a0-f522e1eeaf73" />

On
- <img width="811" height="441" alt="image" src="https://github.com/user-attachments/assets/107842e8-71b6-4975-aef6-24615a08cc80" />



### Csharp
- Run `docker compose up` from the root directory.
- Paste SDK key to Program.cs [L24](https://github.com/jeffrey-vang/FeatBit-JV/blob/e49d9d3bb583ebb3dafe03a8c8d95b0a733aff39/demos/csharp/Program.cs#L24)
- Start program in VS or run `dotnet run CSharpDemo.csproj` from the csharp directory.
- Toggling flag or updating targeting rules should result in a change in logged messages.

  <img width="552" height="286" alt="image" src="https://github.com/user-attachments/assets/cc84459c-6fd0-42c4-85ad-c556492fb2b0" />


